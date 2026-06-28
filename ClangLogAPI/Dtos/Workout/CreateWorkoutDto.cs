using System.ComponentModel.DataAnnotations;

namespace ClangLogAPI.Dtos.Workout
{
    public class CreateWorkoutDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }
    }
}
