using System.ComponentModel.DataAnnotations;

namespace UrenRegistratieAPI.Models
{
    public class Activity
    {
        [Key]
        public int id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TimeSpan TotalTime
        {
            get { return EndTime - StartTime; }
        }
    }
}
