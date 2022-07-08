using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using WinApp.Core;
using WinApp.DataProviders;
using WinApp.SqlProvider;

namespace WinFormsApp
{
    internal static class Program
    {
        public static IConfiguration _configuration { get; private set; }
        public static IServiceProvider _service { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //AddServicesProvider(_configuration);
            
            var host = CreateHostBuilder().Build();
            //  AddServicesProvider(_configuration);
            _service = host.Services;
            Application.Run(_service.GetRequiredService<frmLogin>());
        }

        static IHostBuilder CreateHostBuilder() {
            var connectionString = _configuration.GetConnectionString("DbSqlConnection");
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<GroupAssignmentContext>();
                    services.AddScoped<IUserDataProviders, UserDataProviders>();
                    services.AddScoped<IRoleDataProvider, RoleDataProvider>();
                    services.AddScoped<IMajorDataProvider, MajorDataProvider>();
                    services.AddScoped<frmLogin>();
                    
                });
        }

        public static void AddServicesProvider(
                IConfiguration configuration,
                string connectionStringKey = "DbSqlConnection") {
            var connectionString = configuration.GetConnectionString(connectionStringKey);
            if (string.IsNullOrEmpty(connectionString)) {
                throw new ArgumentNullException($"Connection string {connectionStringKey} is not set.");
            }

            //
            var options = new DbContextOptions<GroupAssignmentContext>();
            var builder = new DbContextOptionsBuilder<GroupAssignmentContext>(options);
            builder.UseSqlServer(connectionString);
            builder.EnableSensitiveDataLogging();
        }
    }
}
