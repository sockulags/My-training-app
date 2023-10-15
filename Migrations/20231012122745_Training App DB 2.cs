using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace traingapp.Migrations
{
    /// <inheritdoc />
    public partial class TrainingAppDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Days_DayId",
                table: "Exercises");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_DayId",
                table: "Exercises");

            migrationBuilder.AddColumn<int>(
                name: "TrainingDayId",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TrainingDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionNumber = table.Column<int>(type: "int", nullable: false),
                    TPID = table.Column<int>(type: "int", nullable: false),
                    TrainingProgramId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingDays_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_TrainingDayId",
                table: "Exercises",
                column: "TrainingDayId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingDays_TrainingProgramId",
                table: "TrainingDays",
                column: "TrainingProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_TrainingDays_TrainingDayId",
                table: "Exercises",
                column: "TrainingDayId",
                principalTable: "TrainingDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_TrainingDays_TrainingDayId",
                table: "Exercises");

            migrationBuilder.DropTable(
                name: "TrainingDays");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_TrainingDayId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "TrainingDayId",
                table: "Exercises");

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingProgramId = table.Column<int>(type: "int", nullable: false),
                    SessionNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Days_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_DayId",
                table: "Exercises",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Days_TrainingProgramId",
                table: "Days",
                column: "TrainingProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Days_DayId",
                table: "Exercises",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
