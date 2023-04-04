using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentMeetingPlanner.Models
{
    public class Speach
    {
        [Required]
        public int Id { get; set; }
        public int PlannerId { get; set; }
        public Planner Planner { get; set; }
        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }
        public int SpeachTopicId { get; set; }
        public SpeachTopic SpeachTopic { get; set; }
    }
}