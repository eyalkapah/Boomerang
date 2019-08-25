using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class AddManyToManyEnrollmentsAndPackages : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackageEnrollments");

            migrationBuilder.AddColumn<int>(
                name: "EnrollmentId",
                table: "Packages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PackageId",
                table: "Enrollments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_EnrollmentId",
                table: "Packages",
                column: "EnrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_PackageId",
                table: "Enrollments",
                column: "PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Packages_PackageId",
                table: "Enrollments",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Enrollments_EnrollmentId",
                table: "Packages",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PackageEnrollments",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(nullable: false),
                    PackageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageEnrollments", x => new { x.EnrollmentId, x.PackageId });
                    table.ForeignKey(
                        name: "FK_PackageEnrollments_Enrollments_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalTable: "Enrollments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageEnrollments_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PackageEnrollments_PackageId",
                table: "PackageEnrollments",
                column: "PackageId");
        }
    }
}