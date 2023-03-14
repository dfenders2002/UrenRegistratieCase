using System.ComponentModel.DataAnnotations;

namespace UrenRegistratieAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string Name { get; set; }
        public int WorkTime { get; set; } = 0;
    }
}
