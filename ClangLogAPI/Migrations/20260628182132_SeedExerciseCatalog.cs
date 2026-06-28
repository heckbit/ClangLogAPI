using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClangLogAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedExerciseCatalog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "MuscleGroup", "Name" },
                values: new object[,]
                {
                    { 1, "Barbell press from a flat bench", "Chest", "Bench Press" },
                    { 2, "Barbell press from an inclined bench", "Chest", "Incline Bench Press" },
                    { 3, "Barbell back squat", "Legs", "Squat" },
                    { 4, "Machine leg press", "Legs", "Leg Press" },
                    { 5, "Conventional barbell deadlift", "Back", "Deadlift" },
                    { 6, "Bent-over barbell row", "Back", "Barbell Row" },
                    { 7, "Bodyweight pull up", "Back", "Pull Up" },
                    { 8, "Standing barbell overhead press", "Shoulders", "Overhead Press" },
                    { 9, "Dumbbell or barbell bicep curl", "Arms", "Bicep Curl" },
                    { 10, "Cable tricep pushdown", "Arms", "Tricep Pushdown" },
                    { 11, "Isometric core hold", "Core", "Plank" },
                    { 12, "Bodyweight or weighted lunges", "Legs", "Lunges" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
