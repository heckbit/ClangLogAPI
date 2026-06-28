using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ClangLogAPI.Enums;

namespace ClangLogAPI.Models
{
    public class ExerciseSet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int WorkoutExerciseId { get; set; }

        [ForeignKey("WorkoutExerciseId")]
        public virtual WorkoutExercise? WorkoutExercise { get; set; }

        public int Repetitions { get; set; }

        public decimal? Weight { get; set; }

        public WeightUnit? WeightUnit { get; set; }
    }
}
