using System;
using System.Collections.Generic;

namespace InnoplixTeamMgmt.Data.Model
{
    public partial class State
    {
        public State()
        {
            Prospects = new HashSet<Prospect>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Prospect> Prospects { get; set; }
    }
}
