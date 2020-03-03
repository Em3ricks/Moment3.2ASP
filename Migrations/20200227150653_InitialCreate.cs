using Microsoft.EntityFrameworkCore.Migrations;

namespace Moment3._2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Album = table.Column<string>(nullable: true),
                    Artist = table.Column<string>(nullable: true),
                    Release = table.Column<int>(nullable: false),
                    Tracks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CD", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CD");
        }
    }
}
