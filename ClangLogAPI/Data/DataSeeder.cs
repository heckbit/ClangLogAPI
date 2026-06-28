using ClangLogAPI.Enums;
using ClangLogAPI.Models;

namespace ClangLogAPI.Data
{
    public static class DataSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            if (context.Users.Any())
                return;

            var users = new List<User>
            {
                new User { Username = "jsmith", Email = "jsmith@example.com", CreatedAt = DateTime.UtcNow },
                new User { Username = "ajohnson", Email = "ajohnson@example.com", CreatedAt = DateTime.UtcNow }
            };

            context.Users.AddRange(users);
            await context.SaveChangesAsync();

            var workouts = new List<Workout>
            {
                new Workout
                {
                    UserId = users[0].Id,
                    StartTime = DateTime.UtcNow.AddDays(-3),
                    EndTime = DateTime.UtcNow.AddDays(-3).AddHours(1),
                    CaloriesBurned = 420
                },
                new Workout
                {
                    UserId = users[0].Id,
                    StartTime = DateTime.UtcNow.AddDays(-1),
                    EndTime = DateTime.UtcNow.AddDays(-1).AddHours(1).AddMinutes(15),
                    CaloriesBurned = 510
                },
                new Workout
                {
                    UserId = users[1].Id,
                    StartTime = DateTime.UtcNow.AddDays(-2),
                    EndTime = DateTime.UtcNow.AddDays(-2).AddHours(1).AddMinutes(30),
                    CaloriesBurned = 380
                }
            };

            context.Workouts.AddRange(workouts);
            await context.SaveChangesAsync();

            var workoutExercises = new List<WorkoutExercise>
            {
                // Workout 1 (jsmith): Bench Press + Squat
                new WorkoutExercise { WorkoutId = workouts[0].Id, ExerciseId = 1 },
                new WorkoutExercise { WorkoutId = workouts[0].Id, ExerciseId = 3 },

                // Workout 2 (jsmith): Deadlift + Barbell Row + Pull Up
                new WorkoutExercise { WorkoutId = workouts[1].Id, ExerciseId = 5 },
                new WorkoutExercise { WorkoutId = workouts[1].Id, ExerciseId = 6 },
                new WorkoutExercise { WorkoutId = workouts[1].Id, ExerciseId = 7 },

                // Workout 3 (ajohnson): Overhead Press + Bicep Curl + Tricep Pushdown
                new WorkoutExercise { WorkoutId = workouts[2].Id, ExerciseId = 8 },
                new WorkoutExercise { WorkoutId = workouts[2].Id, ExerciseId = 9 },
                new WorkoutExercise { WorkoutId = workouts[2].Id, ExerciseId = 10 }
            };

            context.WorkoutExercises.AddRange(workoutExercises);
            await context.SaveChangesAsync();

            var exerciseSets = new List<ExerciseSet>
            {
                // Bench Press sets
                new ExerciseSet { WorkoutExerciseId = workoutExercises[0].Id, Repetitions = 10, Weight = 135, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[0].Id, Repetitions = 8, Weight = 155, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[0].Id, Repetitions = 6, Weight = 175, WeightUnit = WeightUnit.Lbs },

                // Squat sets
                new ExerciseSet { WorkoutExerciseId = workoutExercises[1].Id, Repetitions = 8, Weight = 185, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[1].Id, Repetitions = 8, Weight = 185, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[1].Id, Repetitions = 6, Weight = 205, WeightUnit = WeightUnit.Lbs },

                // Deadlift sets
                new ExerciseSet { WorkoutExerciseId = workoutExercises[2].Id, Repetitions = 5, Weight = 225, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[2].Id, Repetitions = 5, Weight = 245, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[2].Id, Repetitions = 3, Weight = 265, WeightUnit = WeightUnit.Lbs },

                // Barbell Row sets
                new ExerciseSet { WorkoutExerciseId = workoutExercises[3].Id, Repetitions = 10, Weight = 115, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[3].Id, Repetitions = 10, Weight = 115, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[3].Id, Repetitions = 8, Weight = 135, WeightUnit = WeightUnit.Lbs },

                // Pull Up sets (bodyweight)
                new ExerciseSet { WorkoutExerciseId = workoutExercises[4].Id, Repetitions = 10, Weight = null, WeightUnit = null },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[4].Id, Repetitions = 8, Weight = null, WeightUnit = null },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[4].Id, Repetitions = 7, Weight = null, WeightUnit = null },

                // Overhead Press sets
                new ExerciseSet { WorkoutExerciseId = workoutExercises[5].Id, Repetitions = 8, Weight = 95, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[5].Id, Repetitions = 8, Weight = 95, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[5].Id, Repetitions = 6, Weight = 105, WeightUnit = WeightUnit.Lbs },

                // Bicep Curl sets
                new ExerciseSet { WorkoutExerciseId = workoutExercises[6].Id, Repetitions = 12, Weight = 30, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[6].Id, Repetitions = 10, Weight = 35, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[6].Id, Repetitions = 8, Weight = 40, WeightUnit = WeightUnit.Lbs },

                // Tricep Pushdown sets
                new ExerciseSet { WorkoutExerciseId = workoutExercises[7].Id, Repetitions = 12, Weight = 50, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[7].Id, Repetitions = 12, Weight = 50, WeightUnit = WeightUnit.Lbs },
                new ExerciseSet { WorkoutExerciseId = workoutExercises[7].Id, Repetitions = 10, Weight = 60, WeightUnit = WeightUnit.Lbs }
            };

            context.ExerciseSets.AddRange(exerciseSets);
            await context.SaveChangesAsync();
        }
    }
}
