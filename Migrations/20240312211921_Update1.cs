using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW211_MurderMystery.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_PlayerFullName",
                table: "Players");

            migrationBuilder.DropCheckConstraint(
                name: "CK_PlayerGender",
                table: "Players");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Gender",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "PlayerFullName",
                table: "Players",
                newName: "PlayerName");

            migrationBuilder.RenameIndex(
                name: "IX_Players_PlayerFullName",
                table: "Players",
                newName: "IX_Players_PlayerName");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Characters",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "GenderPreference",
                value: "No Preference");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "PlayerName",
                value: "Attendee 4");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "PlayerName",
                value: "Guest 5");

            migrationBuilder.AddCheckConstraint(
                name: "CK_GenderPreference",
                table: "Players",
                sql: "[GenderPreference] IN ('Male', 'Female', 'No Preference')");

            migrationBuilder.AddCheckConstraint(
                name: "CK_PlayerName",
                table: "Players",
                sql: "[PlayerName] NOT LIKE '%[^a-zA-Z0-9 ]%'");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Gender",
                table: "Characters",
                sql: "[Gender] IN ('Male', 'Female')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_GenderPreference",
                table: "Players");

            migrationBuilder.DropCheckConstraint(
                name: "CK_PlayerName",
                table: "Players");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Gender",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "PlayerName",
                table: "Players",
                newName: "PlayerFullName");

            migrationBuilder.RenameIndex(
                name: "IX_Players_PlayerName",
                table: "Players",
                newName: "IX_Players_PlayerFullName");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Characters",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "GenderPreference",
                value: "No preference");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "PlayerFullName",
                value: "Person Four");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "PlayerFullName",
                value: "Person Five");

            migrationBuilder.AddCheckConstraint(
                name: "CK_PlayerFullName",
                table: "Players",
                sql: "[PlayerFullName] NOT LIKE '%[^a-zA-Z0-9 ]%'");

            migrationBuilder.AddCheckConstraint(
                name: "CK_PlayerGender",
                table: "Players",
                sql: "[GenderPreference] IN ('Male', 'Female', 'No preference')");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Gender",
                table: "Characters",
                sql: "[Gender] IN ('Male', 'Female', 'No preference')");
        }
    }
}
