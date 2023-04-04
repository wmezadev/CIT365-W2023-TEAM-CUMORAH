using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int Id { get; set; }


        [Display(Name = "Speaker Name")]
        [Required]
        public string? FullName { get; set; }
    }
}
