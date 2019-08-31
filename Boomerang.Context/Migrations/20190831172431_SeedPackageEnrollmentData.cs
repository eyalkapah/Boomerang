using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class SeedPackageEnrollmentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PackageEnrollments",
                columns: new[] { "EnrollmentId", "PackageId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 }
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
                table: "PackageEnrollments",
                keyColumns: new[] { "EnrollmentId", "PackageId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PackageEnrollments",
                keyColumns: new[] { "EnrollmentId", "PackageId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PackageEnrollments",
                keyColumns: new[] { "EnrollmentId", "PackageId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PackageEnrollments",
                keyColumns: new[] { "EnrollmentId", "PackageId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "PackageEnrollments",
                keyColumns: new[] { "EnrollmentId", "PackageId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PackageEnrollments",
                keyColumns: new[] { "EnrollmentId", "PackageId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PackageEnrollments",
                keyColumns: new[] { "EnrollmentId", "PackageId" },
                keyValues: new object[] { 2, 3 });

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
