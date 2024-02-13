using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW211_MurderMystery.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerFullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PlayerGender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(//I may have to move this later, consulting Joe about it. I have all the seed data ready for when the table is working. -W
                name: "Themes",
                columns: table => new
                {
                    ThemeId = table.Column<int>(type:"int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", maxLength: 150, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.ThemeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
            migrationBuilder.DropTable(
                name: "Themes");
        }
    }
}
