using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace InnoplixTeamMgmt.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public string CompanyName { get; set; }

        public string UniqueId { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Prospect> Prospects { get; set; }
    }
}
