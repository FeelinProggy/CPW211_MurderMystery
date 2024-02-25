using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW211_MurderMystery.Migrations
{
    /// <inheritdoc />
    public partial class AddedBlank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: 1,
                columns: new[] { "Summary", "Title" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: 2,
                columns: new[] { "Summary", "Title" },
                values: new object[] { "The town business tycoon is hosting a mascarade at her manor to celebrate her sons taking over of the family company.", "Mansion Party" });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "ThemeId", "Summary", "Title" },
                values: new object[] { 3, "This train is on a two hour nonstop trip to the next city over. As this specific route goes through the countryside, phone connections are spotty at best.", "Train" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: 1,
                columns: new[] { "Summary", "Title" },
                values: new object[] { "The town business tycoon is hosting a mascarade at her manor to celebrate her sons taking over of the family company.", "Mansion Party" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: 2,
                columns: new[] { "Summary", "Title" },
                values: new object[] { "This train is on a two hour nonstop trip to the next city over. As this specific route goes through the countryside, phone connections are spotty at best.", "Train" });
        }
    }
}
