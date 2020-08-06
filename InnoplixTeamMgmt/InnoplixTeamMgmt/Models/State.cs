using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InnoplixTeamMgmt.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        public virtual ICollection<Prospect> Prospects { get; set; }
    }
}
