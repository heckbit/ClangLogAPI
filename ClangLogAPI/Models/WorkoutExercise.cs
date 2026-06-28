using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClangLogAPI.Models
{
    public class WorkoutExercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int WorkoutId { get; set; }

        [ForeignKey("WorkoutId")]
        public virtual Workout? Workout { get; set; }

        [Required]
        public int ExerciseId { get; set; }

        [ForeignKey("ExerciseId")]
        public virtual Exercise? Exercise { get; set; }

        public ICollection<ExerciseSet> Sets { get; set; } = new List<ExerciseSet>();
    }
}
