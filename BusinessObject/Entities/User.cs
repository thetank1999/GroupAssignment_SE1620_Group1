using System;
using System.Collections.Generic;

#nullable disable

namespace WinApp.SqlProvider
{
    public partial class User
    {
        public User()
        {
            DocumentApprovers = new HashSet<Document>();
            DocumentUploaders = new HashSet<Document>();
            Favourites = new HashSet<Favourite>();
        }

        public int UserId { get; set; }
        public int UserRoleId { get; set; }
        public string UserEmail { get; set; }
        public string UserFullname { get; set; }
        public string UserPassword { get; set; }
        public bool? UserStatus { get; set; }
        public int? UserMajorId { get; set; }

        public virtual Major UserMajor { get; set; }
        public virtual Role UserRole { get; set; }
        public virtual ICollection<Document> DocumentApprovers { get; set; }
        public virtual ICollection<Document> DocumentUploaders { get; set; }
        public virtual ICollection<Favourite> Favourites { get; set; }
    }
}
