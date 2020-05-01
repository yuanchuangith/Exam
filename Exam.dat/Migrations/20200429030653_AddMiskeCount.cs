using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam.dat.Migrations
{
    public partial class AddMiskeCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MistakeNum",
                table: "Topic");

            migrationBuilder.CreateTable(
                name: "TopicMistakeCount",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Topicid = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicMistakeCount", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TopicMistakeCount_Topic_Topicid",
                        column: x => x.Topicid,
                        principalTable: "Topic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TopicMistakeCount_Topicid",
                table: "TopicMistakeCount",
                column: "Topicid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopicMistakeCount");

            migrationBuilder.AddColumn<int>(
                name: "MistakeNum",
                table: "Topic",
                nullable: false,
                defaultValue: 0);
        }
    }
}
