using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class AddRelationFromEnrollmentToSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Enrollments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_SiteId",
                table: "Enrollments",
                column: "SiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Sites_SiteId",
                table: "Enrollments",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Sites_SiteId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_SiteId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Enrollments");
        }
    }
}
