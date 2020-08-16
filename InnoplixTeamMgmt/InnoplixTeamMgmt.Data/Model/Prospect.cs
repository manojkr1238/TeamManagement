using System;
using System.Collections.Generic;

namespace InnoplixTeamMgmt.Data.Model
{
    public partial class Prospect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public int MaritalStatus { get; set; }
        public string Ocuupation { get; set; }
        public string Income { get; set; }
        public string Relation { get; set; }
        public int DegreeOfRelation { get; set; }
        public int Profile { get; set; }
        public string Remarks { get; set; }
        public int ProspectType { get; set; }
        public string UserName { get; set; }
        public int ProspectStatus { get; set; }

        public virtual State State { get; set; }
        public virtual AspNetUser UserNameNavigation { get; set; }
    }
}
