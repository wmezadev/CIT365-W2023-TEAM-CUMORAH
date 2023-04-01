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
        public string? PresideLeader { get; set; }

        [Display(Name = "Conducting Leader")]
        public string? ConductingLeader { get; set; }

        [Display(Name = "Opening Song")]
        public int? OpeningSong { get; set; }

        [Display(Name = "Opening Pray")]
        public string? OpeningPray { get; set; }


        [Display(Name = "Sacrament Hymn")]
        public int? SacramentHymn { get; set; }

        [Display(Name = "Speaker Subject")]
        public string? SpeakerSubject { get; set; }

        [Display(Name = "Closing Song")]
        public int? ClosingSong { get; set; }

        [Display(Name = "Closing Pray")]
        public string? ClosingPray { get; set; }
    }
}
