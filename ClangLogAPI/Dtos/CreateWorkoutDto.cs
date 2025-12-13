using System.ComponentModel.DataAnnotations;

namespace ClangLogAPI.Dtos
{
    public class CreateWorkoutDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }
    }
}
