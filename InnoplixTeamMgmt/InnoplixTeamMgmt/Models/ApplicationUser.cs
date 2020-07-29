using Microsoft.AspNetCore.Identity;

namespace InnoplixTeamMgmt.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public string CompanyName { get; set; }

        public string UniqueId { get; set; }

        public bool IsActive { get; set; }
    }
}
