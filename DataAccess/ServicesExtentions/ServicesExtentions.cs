using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WinApp.Core;
using WinApp.DataProviders;

namespace WinApp.SqlProvider
{
    public static class ServicesExtentions
    {
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
