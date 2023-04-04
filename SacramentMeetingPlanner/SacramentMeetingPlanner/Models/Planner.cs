using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentMeetingPlanner.Models
{
    public class Planner
    {
        public int Id { get; set; }

        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [Display(Name = "Preside Leader")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "The Preside Leader name should start with a capital letter and can only include letters")]
        [Required]
        public string? PresideLeader { get; set; }

        [Display(Name = "Conducting Leader")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "The Conducting Leader name should start with a capital letter and can only include letters")]
        
        [Required]
        public string? ConductingLeader { get; set; }

        [Display(Name = "Opening Song")]
        [Range(1,300)]
        [Required]
        public int? OpeningSong { get; set; }

        [Display(Name = "Opening Pray")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "The Opening Pray name should start with a capital letter and can only include letters")]
        [Required]
        public string? OpeningPray { get; set; }


        [Display(Name = "Sacrament Hymn")]
        [Range(1,300)]
        [Required]
        public int? SacramentHymn { get; set; }

        [Display(Name = "Speaker Subject")]
        [RegularExpression(@"^[a-zA-Z-0-9\s-]*$")]
        [Required]
        public string? SpeakerSubject { get; set; }
        public ICollection<Speach> Speeches { get; set; }

        [Display(Name = "Closing Song")]
        [Range(1, 300)]
        [Required]
        public int? ClosingSong { get; set; }

        [Display(Name = "Closing Pray")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "The Closing Pray name should start with a capital letter and can only include letters")]
        [Required]
        public string? ClosingPray { get; set; }
    }
}
