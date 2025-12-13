using System.ComponentModel.DataAnnotations;

namespace ClangLogAPI.Dtos
{
    public class UpdateWorkoutDto
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [Range(1, 10000)]
        public int CaloriesBurned { get; set; }
    }
}
