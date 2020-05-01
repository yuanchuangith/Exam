using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam.dat.Migrations
{
    public partial class newtopic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewTeacherTopic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(maxLength: 450, nullable: false),
                    Class = table.Column<string>(nullable: false),
                    TopicSytemId = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewTeacherTopic", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NewTeacherTopic_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewTopics",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TopicSytemId = table.Column<string>(maxLength: 1000, nullable: false),
                    title = table.Column<string>(maxLength: 4000, nullable: false),
                    optionONE = table.Column<string>(maxLength: 1000, nullable: false),
                    optionTOW = table.Column<string>(maxLength: 1000, nullable: false),
                    optionTHREE = table.Column<string>(maxLength: 1000, nullable: false),
                    optionFOUR = table.Column<string>(maxLength: 1000, nullable: false),
                    kind = table.Column<string>(maxLength: 100, nullable: false),
                    Degree = table.Column<string>(maxLength: 10, nullable: false),
                    Answer1 = table.Column<string>(maxLength: 1000, nullable: false),
                    Answer2 = table.Column<string>(maxLength: 1000, nullable: false),
                    Answer3 = table.Column<string>(maxLength: 1000, nullable: false),
                    answer4 = table.Column<string>(maxLength: 1000, nullable: false),
                    NewTeacherTopicID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewTopics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NewTopics_NewTeacherTopic_NewTeacherTopicID",
                        column: x => x.NewTeacherTopicID,
                        principalTable: "NewTeacherTopic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewTeacherTopic_UserId",
                table: "NewTeacherTopic",
                column: "UserId");
            migrationBuilder.CreateIndex(
                name: "IX_NewTopics_NewTeacherTopicID",
                table: "NewTopics",
                column: "NewTeacherTopicID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewTopics");

            migrationBuilder.DropTable(
                name: "NewTeacherTopic");
        }
    }
}
