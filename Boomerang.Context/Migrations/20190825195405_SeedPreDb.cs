using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class SeedPreDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PreDbs",
                columns: new[] { "Id", "Bot", "Channel", "IsEnabled", "Name" },
                values: new object[] { 1, "SIDB", "#scumm-pre", true, "SI-DB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreDbs",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
