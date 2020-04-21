using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam.dat.Migrations
{
    public partial class newu1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "answer1",
                table: "Topic",
                newName: "answer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "answer",
                table: "Topic",
                newName: "answer1");
        }
    }
}
