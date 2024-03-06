using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CPW211_MurderMystery.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    ThemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.ThemeId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThemeId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CharScript = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.CheckConstraint("CK_Gender", "[Gender] IN ('Male', 'Female', 'No preference')");
                    table.ForeignKey(
                        name: "FK_Characters_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "ThemeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerFullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GenderPreference = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    AssignedCharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.CheckConstraint("CK_PlayerFullName", "[PlayerFullName] NOT LIKE '%[^a-zA-Z0-9 ]%'");
                    table.CheckConstraint("CK_PlayerGender", "[GenderPreference] IN ('Male', 'Female', 'No preference')");
                    table.ForeignKey(
                        name: "FK_Players_Characters_AssignedCharacterId",
                        column: x => x.AssignedCharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "AssignedCharacterId", "GenderPreference", "PlayerFullName" },
                values: new object[,]
                {
                    { 1, null, "Male", "Player One" },
                    { 2, null, "Female", "Person Two" },
                    { 3, null, "No preference", "User Three" },
                    { 4, null, "Female", "Person Four" },
                    { 5, null, "Female", "Person Five" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "ThemeId", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, "Select a theme for a brief description.", "--Select a theme--" },
                    { 2, "The town business tycoon is hosting a mascarade at her manor to celebrate her sons taking over of the family company.", "Mansion Party" },
                    { 3, "This train is on a two hour nonstop trip to the next city over. As this specific route goes through the countryside, phone connections are spotty at best.", "Train" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CharScript", "Desc", "FullName", "Gender", "Occupation", "ThemeId" },
                values: new object[,]
                {
                    { 1, "TDB", "Father of Deimos, Phobos and Eden", "Mars Olufemi", "Male", "Cartographer", 2 },
                    { 2, "TDB", "Son of Mars, twin brother of Phobos, and elder brother of Eden.", "Deimos Olufemi", "Male", "Singer", 2 },
                    { 3, "TDB", "Son of Mars, twin brother of Deimos, and elder brother of Eden.", "Phobos Olufemi", "Male", "Locksmith", 2 },
                    { 4, "TDB", "Adopted daughter of Mars and younger sister of Deimos and Phobos.", "Eden Olufemi", "Female", "Musician", 2 },
                    { 5, "TDB", "Best friend of Phoebe.", "Tahlia Collins", "Female", "Gardener", 2 },
                    { 6, "TDB", "Best friend of Tahlia.", "Phoebe Mandrapilias", "Female", "Painter", 3 },
                    { 7, "TDB", "Wife/business partner of Walter and mother of Jamie.", "Silvia Honey", "Female", "Shop Owner", 3 },
                    { 8, "TDB", "Husband/business partner of Silvia and father of Jamie.", "Walter Honey", "Male", "Shop Owner", 3 },
                    { 9, "TDB", "Son of Walter and Silvia. Jamie was often babysat by Deimos as a child, and the two are still very close to this day. Jamie is also friends with Elliot, and often spends time in his library. Although, while the two enjoy talking, Jamie can’t say he knows much about Elliot personally.", "Jamie Honey", "Male", "Waiter", 3 },
                    { 10, "TDB", "Friend of Jamie, but much of his past is a mystery to Jamie.", "Elliot Perry", "Male", "Librarian", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ThemeId",
                table: "Characters",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_AssignedCharacterId",
                table: "Players",
                column: "AssignedCharacterId",
                unique: true,
                filter: "[AssignedCharacterId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Players_PlayerFullName",
                table: "Players",
                column: "PlayerFullName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Themes");
        }
    }
}
