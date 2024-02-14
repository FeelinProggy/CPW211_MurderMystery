using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CPW211_MurderMystery.Migrations
{
    /// <inheritdoc />
    public partial class CharacterSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CharScript", "Desc", "FullName", "Gender", "Occupation" },
                values: new object[,]
                {
                    { 1, "TDB", "Father of Deimos, Phobos and Eden", "Mars Olufemi", "Male", "Cartographer" },
                    { 2, "TDB", "Son of Mars, twin brother of Phobos, and elder brother of Eden.", "Deimos Olufemi", "Male", "Singer" },
                    { 3, "TDB", "Son of Mars, twin brother of Deimos, and elder brother of Eden.", "Phobos Olufemi", "Male", "Locksmith" },
                    { 4, "TDB", "Adopted daughter of Mars and younger sister of Deimos and Phobos.", "Eden Olufemi", "Female", "Musician" },
                    { 5, "TDB", "Best friend of Phoebe.", "Tahlia Collins", "Female", "Gardener" },
                    { 6, "TDB", "Best friend of Tahlia.", "Phoebe Mandrapilias", "Female", "Painter" },
                    { 7, "TDB", "Wife/business partner of Walter and mother of Jamie.", "Silvia Honey", "Female", "Shop Owner" },
                    { 8, "TDB", "Husband/business partner of Silvia and father of Jamie.", "Walter Honey", "Male", "Shop Owner" },
                    { 9, "TDB", "Son of Walter and Silvia. Jamie was often babysat by Deimos as a child, and the two are still very close to this day. Jamie is also friends with Elliot, and often spends time in his library. Although, while the two enjoy talking, Jamie can’t say he knows much about Elliot personally.", "Jamie Honey", "Male", "Waiter" },
                    { 10, "TDB", "Friend of Jamie, but much of his past is a mystery to Jamie.", "Elliot Perry", "Male", "Librarian" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10);
        }
    }
}
