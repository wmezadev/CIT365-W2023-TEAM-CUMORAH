using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentMeetingPlanner.Models
{
    public class SpeachTopic
    {
        public int Id { get; set; }


        [Display(Name = "Topic Name")]
        [Required]
        public string? TopicName { get; set; }
    }
}
