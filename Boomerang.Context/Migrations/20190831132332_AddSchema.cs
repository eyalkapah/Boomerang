using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class AddSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(256)", nullable: false),
                    Name = table.Column<string>(type: "varchar(32)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComplexWords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(32)", nullable: false),
                    Description = table.Column<string>(type: "varchar(256)", nullable: false),
                    Classification = table.Column<string>(type: "varchar(64)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplexWords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreDbs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bot = table.Column<string>(type: "varchar(32)", nullable: false),
                    Channel = table.Column<string>(type: "varchar(64)", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "varchar(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreDbs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Releases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(256)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Releases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaxDownloadLogins = table.Column<int>(type: "int", nullable: false),
                    MaxUploadLogins = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(16)", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TotalLogins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(32)", nullable: false),
                    Description = table.Column<string>(type: "varchar(256)", nullable: false),
                    Classification = table.Column<string>(type: "varchar(64)", nullable: false),
                    IgnorePattern = table.Column<string>(type: "varchar(2048)", nullable: true),
                    Pattern = table.Column<string>(type: "varchar(2048)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IrcInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bot = table.Column<string>(nullable: true),
                    Channel = table.Column<string>(nullable: true),
                    SiteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IrcInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IrcInfo_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComplexWordMap",
                columns: table => new
                {
                    ComplexWordId = table.Column<int>(nullable: false),
                    WordId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplexWordMap", x => new { x.WordId, x.ComplexWordId });
                    table.ForeignKey(
                        name: "FK_ComplexWordMap_ComplexWords_ComplexWordId",
                        column: x => x.ComplexWordId,
                        principalTable: "ComplexWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComplexWordMap_Words_WordId",
                        column: x => x.WordId,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Applicability = table.Column<int>(type: "int", nullable: false),
                    ComplexWordId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(type: "varchar(256)", nullable: true),
                    Name = table.Column<string>(type: "varchar(128)", nullable: false),
                    WordId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packages_ComplexWords_ComplexWordId",
                        column: x => x.ComplexWordId,
                        principalTable: "ComplexWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Packages_Words_WordId",
                        column: x => x.WordId,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BubbleLevel = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Delimiter = table.Column<string>(type: "char", nullable: false),
                    Description = table.Column<string>(type: "varchar(256)", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "varchar(32)", nullable: false),
                    PackageId = table.Column<int>(nullable: false),
                    RaceActivityInSeconds = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Affils = table.Column<string>(type: "varchar(512)", nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    SiteId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollments_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplexWordMap_ComplexWordId",
                table: "ComplexWordMap",
                column: "ComplexWordId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_SectionId",
                table: "Enrollments",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_SiteId",
                table: "Enrollments",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_IrcInfo_SiteId",
                table: "IrcInfo",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageEnrollments_PackageId",
                table: "PackageEnrollments",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_ComplexWordId",
                table: "Packages",
                column: "ComplexWordId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_WordId",
                table: "Packages",
                column: "WordId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CategoryId",
                table: "Sections",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_PackageId",
                table: "Sections",
                column: "PackageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplexWordMap");

            migrationBuilder.DropTable(
                name: "IrcInfo");

            migrationBuilder.DropTable(
                name: "PackageEnrollments");

            migrationBuilder.DropTable(
                name: "PreDbs");

            migrationBuilder.DropTable(
                name: "Releases");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "ComplexWords");

            migrationBuilder.DropTable(
                name: "Words");
        }
    }
}
