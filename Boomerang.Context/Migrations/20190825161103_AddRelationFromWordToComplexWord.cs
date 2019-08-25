using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class AddRelationFromWordToComplexWord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComplexWordId",
                table: "Words",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Words_ComplexWordId",
                table: "Words",
                column: "ComplexWordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Words_ComplexWords_ComplexWordId",
                table: "Words",
                column: "ComplexWordId",
                principalTable: "ComplexWords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_ComplexWords_ComplexWordId",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Words_ComplexWordId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "ComplexWordId",
                table: "Words");
        }
    }
}
