using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoplixTeamMgmt.Models
{
    public class Prospect
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Age is required!")]
        [Range(minimum:18, maximum:99, ErrorMessage = "Age must be between 18 to 99 years only!")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Mobile Number is required!")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "City is required!")]
        public string City { get; set; }

        [Required(ErrorMessage = "Select State!")]
        [Range(1, int.MaxValue, ErrorMessage = "Select State!")]
        [Display(Name="State")]
        public int? StateId { get; set; }

        [Required(ErrorMessage = "Marital Status is required!")]
        [Range(1, int.MaxValue, ErrorMessage = "Marital Status is required!")]
        public MaritalStatus? MaritalStatus { get; set; }

        public string Ocuupation { get; set; }

        public string Income { get; set; }

        [Required(ErrorMessage = "Relation is required!")]
        public string Relation { get; set; }

        [Display(Name = "Degree Of Relation")]
        [Required(ErrorMessage = "Select Degree Of Relation!")]
        public DegreeOfRelation DegreeOfRelation { get; set; }

        [Required(ErrorMessage = "Profile is required!")]
        public Profile Profile { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Prospect Type")]
        [Required(ErrorMessage = "Select Prospect Type!")]
        public ProspectType ProspectType { get; set; }

        [ForeignKey("UserName")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public ProspectStatus ProspectStatus { get; set; }

        [ForeignKey("StateId")]
        public virtual State State { get; set; }
    }
}
