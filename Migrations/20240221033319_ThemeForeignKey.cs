using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW211_MurderMystery.Migrations
{
    /// <inheritdoc />
    public partial class ThmeForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ThemeId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "ThemeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                column: "ThemeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3,
                column: "ThemeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 4,
                column: "ThemeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 5,
                column: "ThemeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 6,
                column: "ThemeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 7,
                column: "ThemeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 8,
                column: "ThemeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 9,
                column: "ThemeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10,
                column: "ThemeId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ThemeId",
                table: "Characters",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Themes_ThemeId",
                table: "Characters",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "ThemeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Themes_ThemeId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_ThemeId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ThemeId",
                table: "Characters");
        }
    }
}
