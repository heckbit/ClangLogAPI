using Microsoft.EntityFrameworkCore;
using ClangLogAPI.Models;

namespace ClangLogAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Workout> Workouts { get; set; }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }

        public DbSet<ExerciseSet> ExerciseSets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise { Id = 1, Name = "Bench Press", MuscleGroup = "Chest", Description = "Barbell press from a flat bench" },
                new Exercise { Id = 2, Name = "Incline Bench Press", MuscleGroup = "Chest", Description = "Barbell press from an inclined bench" },
                new Exercise { Id = 3, Name = "Squat", MuscleGroup = "Legs", Description = "Barbell back squat" },
                new Exercise { Id = 4, Name = "Leg Press", MuscleGroup = "Legs", Description = "Machine leg press" },
                new Exercise { Id = 5, Name = "Deadlift", MuscleGroup = "Back", Description = "Conventional barbell deadlift" },
                new Exercise { Id = 6, Name = "Barbell Row", MuscleGroup = "Back", Description = "Bent-over barbell row" },
                new Exercise { Id = 7, Name = "Pull Up", MuscleGroup = "Back", Description = "Bodyweight pull up" },
                new Exercise { Id = 8, Name = "Overhead Press", MuscleGroup = "Shoulders", Description = "Standing barbell overhead press" },
                new Exercise { Id = 9, Name = "Bicep Curl", MuscleGroup = "Arms", Description = "Dumbbell or barbell bicep curl" },
                new Exercise { Id = 10, Name = "Tricep Pushdown", MuscleGroup = "Arms", Description = "Cable tricep pushdown" },
                new Exercise { Id = 11, Name = "Plank", MuscleGroup = "Core", Description = "Isometric core hold" },
                new Exercise { Id = 12, Name = "Lunges", MuscleGroup = "Legs", Description = "Bodyweight or weighted lunges" }
            );
        }
    }
}
