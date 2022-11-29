using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnoConference.Models
{
    [Table("Events")]
    public class Events
    {
        [Key]
        public Guid eventId { get; set; }
        public string eventTitle { get; set; }
        public string description { get; set; }
        public DateTime eventdate { get; set; }
        public bool status { get; set; }
        public string venue { get; set; }
        public string website { get; set; }
        [ForeignKey("Speakers")]
        public Guid speakerId { get; set; }

    }
}
