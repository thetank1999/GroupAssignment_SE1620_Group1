using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace WinApp.SqlProvider
{
    public partial class GroupAssignmentContext : DbContext
    {
        public IConfiguration _configuration { get; private set; }

        public GroupAssignmentContext(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public GroupAssignmentContext(DbContextOptions<GroupAssignmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Favourite> Favourites { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            this._configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer(this._configuration.GetConnectionString("DbSqlConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.CategoryStatus)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("Document");

                entity.Property(e => e.DocumentData).IsRequired();

                entity.Property(e => e.DocumentStatus)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.DocumentUrl)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.HasOne(d => d.Approver)
                    .WithMany(p => p.DocumentApprovers)
                    .HasForeignKey(d => d.ApproverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_User1");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_Category");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.MajorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_Major");

                entity.HasOne(d => d.Uploader)
                    .WithMany(p => p.DocumentUploaders)
                    .HasForeignKey(d => d.UploaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_User");
            });

            modelBuilder.Entity<Favourite>(entity =>
            {
                entity.ToTable("Favourite");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.Favourites)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favourite_Document");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Favourites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favourite_User");
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.ToTable("Major");

                entity.Property(e => e.MajorName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.MajorStatus)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.RoleStatus)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.UserFullname)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.UserStatus)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.UserMajorNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserMajor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Major");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
