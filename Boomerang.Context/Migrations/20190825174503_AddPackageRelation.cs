using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class AddPackageRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComplexWordId",
                table: "Packages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WordId",
                table: "Packages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_ComplexWordId",
                table: "Packages",
                column: "ComplexWordId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_WordId",
                table: "Packages",
                column: "WordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_ComplexWords_ComplexWordId",
                table: "Packages",
                column: "ComplexWordId",
                principalTable: "ComplexWords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Words_WordId",
                table: "Packages",
                column: "WordId",
                principalTable: "Words",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_ComplexWords_ComplexWordId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Words_WordId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_ComplexWordId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_WordId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "ComplexWordId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "WordId",
                table: "Packages");
        }
    }
}
