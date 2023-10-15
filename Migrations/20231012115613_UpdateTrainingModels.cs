using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace traingapp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTrainingModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TPID",
                table: "Days");

            migrationBuilder.RenameColumn(
                name: "Set",
                table: "Exercises",
                newName: "Sets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sets",
                table: "Exercises",
                newName: "Set");

            migrationBuilder.AddColumn<int>(
                name: "TPID",
                table: "Days",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
