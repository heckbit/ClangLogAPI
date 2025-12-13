namespace ClangLogAPI.Dtos
{
    public class GetWorkoutDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int CaloriesBurned { get; set; }

        public double DurationInMinutes => (EndTime - StartTime).TotalMinutes;
    }
}
