using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class AlterRelationFromWordToComplexWord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_ComplexWords_ComplexWordId",
                table: "Words");

            migrationBuilder.AlterColumn<int>(
                name: "ComplexWordId",
                table: "Words",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Words_ComplexWords_ComplexWordId",
                table: "Words",
                column: "ComplexWordId",
                principalTable: "ComplexWords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_ComplexWords_ComplexWordId",
                table: "Words");

            migrationBuilder.AlterColumn<int>(
                name: "ComplexWordId",
                table: "Words",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Words_ComplexWords_ComplexWordId",
                table: "Words",
                column: "ComplexWordId",
                principalTable: "ComplexWords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
