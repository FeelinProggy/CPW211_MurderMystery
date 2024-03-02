using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW211_MurderMystery.Migrations
{
    /// <inheritdoc />
    public partial class AddPlayerFullNameCheckConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: 1,
                columns: new[] { "Summary", "Title" },
                values: new object[] { "Please select a theme.", "--Select a theme--" });

            migrationBuilder.CreateIndex(
                name: "IX_Players_PlayerFullName",
                table: "Players",
                column: "PlayerFullName",
                unique: true);

            migrationBuilder.AddCheckConstraint(
                name: "CK_PlayerFullName",
                table: "Players",
                sql: "[PlayerFullName] NOT LIKE '%[^a-zA-Z0-9 ]%'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Players_PlayerFullName",
                table: "Players");

            migrationBuilder.DropCheckConstraint(
                name: "CK_PlayerFullName",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: 1,
                columns: new[] { "Summary", "Title" },
                values: new object[] { " ", "        " });
        }
    }
}
