using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using InnoplixTeamMgmt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using InnoplixTeamMgmt.DAL.Models;

namespace InnoplixTeamMgmt.DAL
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<DynamixTeamContext>
    {
        public DynamixTeamContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<DynamixTeamContext>();
            var connectionString = configuration.GetConnectionString("DatabaseConnection");
            builder.UseSqlServer(connectionString);
            return new DynamixTeamContext(builder.Options);
        }
    }
}
