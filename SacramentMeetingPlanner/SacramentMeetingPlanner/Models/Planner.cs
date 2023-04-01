using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models;

public class Planner
{
    public int Id { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateMeeting { get; set; }
    public string? ConductionLeader { get; set; }

    public string? OpeningSong { get; set; }

    public string? OpeningPray { get; set; }

    public int? HymnNumber { get; set; } = 0;

    public string? ClosingPray { get; set; }
   
    public string? SpeakerSubject { get; set; }
}
