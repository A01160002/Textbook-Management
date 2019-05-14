using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Textbook_Management.Data.Migrations
{
    public partial class TextbookManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Did = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Did);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Cid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cname = table.Column<string>(nullable: true),
                    Did = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Cid);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_Did",
                        column: x => x.Did,
                        principalTable: "Departments",
                        principalColumn: "Did",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sname = table.Column<string>(nullable: true),
                    Sbirth = table.Column<string>(nullable: true),
                    Sgender = table.Column<string>(nullable: true),
                    Stel = table.Column<string>(nullable: true),
                    Saddr = table.Column<string>(nullable: true),
                    Did = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Sid);
                    table.ForeignKey(
                        name: "FK_Students_Departments_Did",
                        column: x => x.Did,
                        principalTable: "Departments",
                        principalColumn: "Did",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Bid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bname = table.Column<string>(nullable: true),
                    Bremain = table.Column<string>(nullable: true),
                    Blaunch = table.Column<string>(nullable: true),
                    Cid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Bid);
                    table.ForeignKey(
                        name: "FK_Books_Courses_Cid",
                        column: x => x.Cid,
                        principalTable: "Courses",
                        principalColumn: "Cid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Cid",
                table: "Books",
                column: "Cid");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Did",
                table: "Courses",
                column: "Did");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Did",
                table: "Students",
                column: "Did");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
