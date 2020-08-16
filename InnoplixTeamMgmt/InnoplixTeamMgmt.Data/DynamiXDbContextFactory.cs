using InnoplixTeamMgmt.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace InnoplixTeamMgmt.Data
{
    public class DynamiXDbContextFactory : IDesignTimeDbContextFactory<DynamixTeamDbContext>
    {
        public DynamixTeamDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<DynamixTeamDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new DynamixTeamDbContext(builder.Options);
        }
    }
}
