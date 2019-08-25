using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class SeedAudioCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[] { 1, "Audio Category", "Audio", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
