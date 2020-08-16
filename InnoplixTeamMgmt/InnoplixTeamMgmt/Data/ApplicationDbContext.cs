using InnoplixTeamMgmt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InnoplixTeamMgmt.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Prospect> Prospects { get; set; }

        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Prospect>().ToTable("Prospect");
            builder.Entity<State>().ToTable("State");
            base.OnModelCreating(builder);
        }
    }
}
