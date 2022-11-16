using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentProgressReportSystem.Migrations
{
    public partial class NextCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "progress",
                columns: table => new
                {
                    Sno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Batch = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<int>(type: "int", nullable: false),
                    Math = table.Column<int>(type: "int", nullable: false),
                    Science = table.Column<int>(type: "int", nullable: false),
                    Social = table.Column<int>(type: "int", nullable: false),
                    Nepali = table.Column<int>(type: "int", nullable: false),
                    Computer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_progress", x => x.Sno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "progress");
        }
    }
}
