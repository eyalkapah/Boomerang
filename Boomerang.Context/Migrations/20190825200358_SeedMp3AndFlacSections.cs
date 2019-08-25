using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class SeedMp3AndFlacSections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "BubbleLevel", "CategoryId", "Delimiter", "Description", "IsEnabled", "Name", "RaceActivityInSeconds" },
                values: new object[] { 1, 0, 1, "-", "Mp3 Section", true, "Mp3", 600 });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "BubbleLevel", "CategoryId", "Delimiter", "Description", "IsEnabled", "Name", "RaceActivityInSeconds" },
                values: new object[] { 2, 0, 1, "-", "Flac Section", true, "Flac", 600 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
