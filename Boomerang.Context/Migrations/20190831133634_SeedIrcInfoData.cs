using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class SeedIrcInfoData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "IrcInfo",
                columns: new[] { "Id", "Bot", "Channel", "SiteId" },
                values: new object[,]
                {
                    { 1, "pf-bot", "pf-spam", 1 },
                    { 2, "PiEcE", "#puzzlefactory", 1 },
                    { 3, "bh-bot", "bh-spam", 2 },
                    { 4, "bh", "#biohazzard", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                column: "Delimiter",
                value: "-");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                column: "Delimiter",
                value: "-");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IrcInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IrcInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IrcInfo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IrcInfo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                column: "Delimiter",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                column: "Delimiter",
                value: null);
        }
    }
}
