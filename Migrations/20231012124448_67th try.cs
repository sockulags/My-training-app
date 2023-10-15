using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace traingapp.Migrations
{
    /// <inheritdoc />
    public partial class _67thtry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_TrainingDays_TrainingDayId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_TrainingDayId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "SessionNumber",
                table: "TrainingDays");

            migrationBuilder.DropColumn(
                name: "TPID",
                table: "TrainingDays");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Reps",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "RestInSeconds",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Sets",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "TrainingDayId",
                table: "Exercises");

            migrationBuilder.CreateTable(
                name: "TrainingDayExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingDayId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    RestInSeconds = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingDayExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingDayExercises_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingDayExercises_TrainingDays_TrainingDayId",
                        column: x => x.TrainingDayId,
                        principalTable: "TrainingDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingDayExercises_ExerciseId",
                table: "TrainingDayExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingDayExercises_TrainingDayId",
                table: "TrainingDayExercises",
                column: "TrainingDayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingDayExercises");

            migrationBuilder.AddColumn<int>(
                name: "SessionNumber",
                table: "TrainingDays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TPID",
                table: "TrainingDays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayId",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Reps",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RestInSeconds",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sets",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingDayId",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_TrainingDayId",
                table: "Exercises",
                column: "TrainingDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_TrainingDays_TrainingDayId",
                table: "Exercises",
                column: "TrainingDayId",
                principalTable: "TrainingDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
