using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InnoplixTeamMgmt.Models
{
    public enum MaritalStatus
    {
        Single = 1,
        Married = 2,
        Widowed = 3,
        Divorced = 4,
        Separated = 5
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }

    public enum DegreeOfRelation
    {
        Hot = 1,
        Warm = 2,
        Cold = 3
    }

    public enum Profile
    {
        Above = 1,
        Equal = 2,
        Below = 3
    }

    public enum ProspectType
    {
        Prospect = 1,
        Customer = 2,
        Both = 3
    }

    public enum ProspectStatus
    {
        New = 1,

        [Display(Name = "Bop done")]
        BOPDone = 2,

        [Display(Name = "Follow up in progress")]
        FollowUpInProgress = 3,

        [Display(Name = "Sale closed")]
        SaleClosed = 4,

        [Display(Name = "Case closed")]
        CaseClosed = 5
    }
}
