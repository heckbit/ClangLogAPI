using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClangLogAPI.Data;
using ClangLogAPI.Models;
using ClangLogAPI.Dtos;

namespace ClangLogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkoutController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetWorkoutDto>>> GetWorkouts()
        {
            var workouts = await _context.Workouts.ToListAsync();

            var workoutDtos = workouts.Select(w => new GetWorkoutDto
            {
                Id = w.Id,
                UserId = w.UserId,
                StartTime = w.StartTime,
                EndTime = w.EndTime,
                CaloriesBurned = w.CaloriesBurned
            }).ToList();

            return Ok(workoutDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetWorkoutDto>> GetWorkout(int id)
        {
            var workout = await _context.Workouts.FindAsync(id);

            if (workout == null)
            {
                return NotFound();
            }

            var workoutDto = new GetWorkoutDto
            {
                Id = workout.Id,
                UserId = workout.UserId,
                StartTime = workout.StartTime,
                EndTime = workout.EndTime,
                CaloriesBurned = workout.CaloriesBurned
            };

            return Ok(workout);
        }

        [HttpPost]
        public async Task<ActionResult<GetWorkoutDto>> CreateWorkout(CreateWorkoutDto createWorkoutDto)
        {
            var workout = new Workout
            {
                UserId = createWorkoutDto.UserId,
                StartTime = createWorkoutDto.StartTime
            };

            _context.Workouts.Add(workout);
            await _context.SaveChangesAsync();

            var newWorkoutDto = new GetWorkoutDto
            {
                Id = workout.Id,
                UserId = workout.UserId,
                StartTime = workout.StartTime,
                EndTime = workout.EndTime,
                CaloriesBurned = workout.CaloriesBurned
            };

            return CreatedAtAction(nameof(GetWorkout), new { id = workout.Id }, newWorkoutDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWorkout(int id, UpdateWorkoutDto updateWorkoutDto)
        {
            var workout = await _context.Workouts.FindAsync(id);

            if (workout == null)
            {
                return NotFound();
            }

            workout.EndTime = updateWorkoutDto.EndTime;
            workout.CaloriesBurned = updateWorkoutDto.CaloriesBurned;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Workouts.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkout(int id)
        {
            var workout = await _context.Workouts.FindAsync(id);

            if (workout == null)
            {
                return NotFound();
            }

            _context.Workouts.Remove(workout);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
