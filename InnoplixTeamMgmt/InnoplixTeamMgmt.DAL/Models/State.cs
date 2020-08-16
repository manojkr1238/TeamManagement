using System;
using System.Collections.Generic;

namespace InnoplixTeamMgmt.DAL.Models
{
    public partial class State
    {
        public State()
        {
            Prospect = new HashSet<Prospect>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Prospect> Prospect { get; set; }
    }
}
