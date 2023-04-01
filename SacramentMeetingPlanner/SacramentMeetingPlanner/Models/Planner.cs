using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Planner
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }
        public string? ConductingLeader { get; set; }
        public int? OpeningSong { get; set; }

        public string? OpeningPray { get; set; }

        public int? SacramentHymn { get; set; }

        public string? SpeakerSubject { get; set; }

        public int? ClosingSong { get; set; }

        public string? ClosingPray { get; set; }
    }
}
