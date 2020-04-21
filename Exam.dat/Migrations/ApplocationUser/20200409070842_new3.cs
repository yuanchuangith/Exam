using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam.dat.Migrations.ApplocationUser
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Signature",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
