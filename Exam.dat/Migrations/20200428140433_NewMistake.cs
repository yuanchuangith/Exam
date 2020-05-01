using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam.dat.Migrations
{
    public partial class NewMistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dateTime",
                table: "NewTeacherTopic",
                newName: "DateTime");

            migrationBuilder.AddColumn<int>(
                name: "MistakeNum",
                table: "Topic",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MistakeNum",
                table: "NewTopics",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MistakeNum",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "MistakeNum",
                table: "NewTopics");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "NewTeacherTopic",
                newName: "dateTime");
        }
    }
}
