using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClangLogAPI.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        public string? Email { get; set; }

        public DateTime CreatedAt { get; set; } 

        public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
    }
}
