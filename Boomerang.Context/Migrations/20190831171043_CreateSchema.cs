using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class CreateSchema : Migration
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[] { 1, "Audio Category", "audio", 1 });

            migrationBuilder.InsertData(
                table: "ComplexWords",
                columns: new[] { "Id", "Classification", "Description", "Name" },
                values: new object[] { 1, "SOURCES", "Live regex", "Live" });

            migrationBuilder.InsertData(
                table: "PreDbs",
                columns: new[] { "Id", "Bot", "Channel", "IsEnabled", "Name" },
                values: new object[,]
                {
                    { 1, "SIDB", "#scumm-pre", false, "SIDB" },
                    { 2, "ARDB", "#Panicpre", false, "ARDB" }
                });

            migrationBuilder.InsertData(
                table: "Sites",
                columns: new[] { "Id", "MaxDownloadLogins", "MaxUploadLogins", "Name", "Rank", "Status", "TotalLogins" },
                values: new object[,]
                {
                    { 1, 2, 2, "PF", 6, 1, 2 },
                    { 2, 2, 2, "BH", 6, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Classification", "Description", "IgnorePattern", "Name", "Pattern" },
                values: new object[,]
                {
                    { 21, "SOURCES", "Digipak regex", null, "DIGIPAK", "[%delimiter%](digipak)[%delimiter%]" },
                    { 22, "SOURCES", "Tape regex", null, "TAPE", "[%delimiter%](tape|mixtape)[%delimiter%]" },
                    { 23, "SOURCES", "Audio book regex", null, "ABOOK", "[%delimiter%](abook|audiobook)[%delimiter%]" },
                    { 24, "SOURCES", "Cdm regex", null, "CDM", "[%delimiter%](cdm)[%delimiter%]" },
                    { 25, "SOURCES", "Cds regex", null, "CDS", "[%delimiter%](cds)[%delimiter%]" },
                    { 26, "SOURCES", "Live in regex", null, "LIVE_IN", "[%delimiter%](live_in)[%delimiter%]" },
                    { 27, "SOURCES", "Live at regex", null, "LIVE_AT", "[%delimiter%](live_at)[%delimiter%]" },
                    { 30, "SOURCES", "Dat regex", null, "DAT", "[%delimiter%](dat)[%delimiter%]" },
                    { 29, "SOURCES", "Dvb regex", null, "DVB", "[%delimiter%](dvb(s)?)[%delimiter%]" },
                    { 20, "XPOP", "Foreign pop regex", null, "xPOP", "[%delimiter%]((K|X|J)POP)[%delimiter%]" },
                    { 31, "SOURCES", "Sbd regex", null, "SBD", "[%delimiter%](sbd)[%delimiter%]" },
                    { 32, "SOURCES", "dab regex", null, "DAB", "[%delimiter%](dab)[%delimiter%]" },
                    { 33, "SOURCES", "Radio regex", null, "RADIO", "[%delimiter%](radio)[%delimiter%]" },
                    { 34, "SOURCES", "Line regex", null, "LINE", "[%delimiter%](line)[%delimiter%]" },
                    { 35, "SOURCES", "FreshFM regex", null, "FRESHFM", "[%delimiter%](freshfm)[%delimiter%]" },
                    { 28, "SOURCES", "Cable regex", null, "CABLE", "[%delimiter%](cable)[%delimiter%]" },
                    { 19, "SOURCES", "Promo regex", null, "PROMO", "[%delimiter%](promo)[%delimiter%]" },
                    { 16, "SOURCES", "Vinyl regex", null, "VINYL", "[%delimiter%](vinyl|vls|ep|lp)[%delimiter%]" },
                    { 17, "SOURCES", "Web regex", null, "WEB", "[%delimiter%](web|freeweb)[%delimiter%]" },
                    { 1, "SECTION", "Mp3 section", null, "MP3", "(mp3)" },
                    { 2, "LANGUAGES", "English language only", null, "EN_ONLY", "[%delimiter%](aa|ab|ae|af|ak|am|an|ar|as|av|ay|az|ba|be|bg|bh|bi|bm|bn|bo|br|bs|ca|ce|ch|co|cr|cs|cu|cv|cy|da|de|dv|dz|ee|el|en|eo|es|et|eu|fa|ff|fi|fj|fo|fr|fy|ga|gd|gl|gn|gu|gv|ha|he|hi|ho|hr|ht|hu|hy|hz|ia|id|ie|ig|ii|ik|io|is|it|iu|ja|jv|ka|kg|ki|kj|kk|kl|km|kn|ko|kr|ks|ku|kv|kw|ky|la|lb|lg|li|ln|lo|lt|lu|lv|mg|mh|mi|mk|ml|mn|mr|ms|mt|my|na|nb|nd|ne|ng|nl|nn|no|nr|nv|ny|oc|oj|om|or|os|pa|pi|pl|ps|pt|qu|rm|rn|ro|ru|rw|sa|sc|sd|se|sg|si|sk|sl|sm|sn|so|sq|sr|ss|st|su|sv|sw|ta|te|tg|th|ti|tk|tl|tn|to|tr|ts|tt|tw|ty|ug|uk|ur|uz|ve|vi|vo|wa|wo|xh|yi|yo|za|zh|zu)[%delimiter%]" },
                    { 3, "LANGUAGES", "English and Dutch language only", null, "EN_AND_DUTCH", "[%delimiter%](aa|ab|ae|af|ak|am|an|ar|as|av|ay|az|ba|be|bg|bh|bi|bm|bn|bo|br|bs|ca|ce|ch|co|cr|cs|cu|cv|cy|da|de|dv|dz|ee|el|en|eo|es|et|eu|fa|ff|fi|fj|fo|fr|fy|ga|gd|gl|gn|gu|gv|ha|he|hi|ho|hr|ht|hu|hy|hz|ia|id|ie|ig|ii|ik|io|is|it|iu|ja|jv|ka|kg|ki|kj|kk|kl|km|kn|ko|kr|ks|ku|kv|kw|ky|la|lb|lg|li|ln|lo|lt|lu|lv|mg|mh|mi|mk|ml|mn|mr|ms|mt|my|na|nb|nd|ne|ng|nl|nn|no|nr|nv|ny|oc|oj|om|or|os|pa|pi|pl|ps|pt|qu|rm|rn|ro|ru|rw|sa|sc|sd|se|sg|si|sk|sl|sm|sn|so|sq|sr|ss|st|su|sv|sw|ta|te|tg|th|ti|tk|tl|tn|to|tr|ts|tt|tw|ty|ug|uk|ur|uz|ve|vi|vo|wa|wo|xh|yi|yo|za|zh|zu)[%delimiter%]" },
                    { 4, "LANGUAGES", "Allow all languages except for Hebrew", null, "HE banned", "[%delimiter%](aa|ab|ae|af|ak|am|an|ar|as|av|ay|az|ba|be|bg|bh|bi|bm|bn|bo|br|bs|ca|ce|ch|co|cr|cs|cu|cv|cy|da|de|dv|dz|ee|el|en|eo|es|et|eu|fa|ff|fi|fj|fo|fr|fy|ga|gd|gl|gn|gu|gv|ha|he|hi|ho|hr|ht|hu|hy|hz|ia|id|ie|ig|ii|ik|io|is|it|iu|ja|jv|ka|kg|ki|kj|kk|kl|km|kn|ko|kr|ks|ku|kv|kw|ky|la|lb|lg|li|ln|lo|lt|lu|lv|mg|mh|mi|mk|ml|mn|mr|ms|mt|my|na|nb|nd|ne|ng|nl|nn|no|nr|nv|ny|oc|oj|om|or|os|pa|pi|pl|ps|pt|qu|rm|rn|ro|ru|rw|sa|sc|sd|se|sg|si|sk|sl|sm|sn|so|sq|sr|ss|st|su|sv|sw|ta|te|tg|th|ti|tk|tl|tn|to|tr|ts|tt|tw|ty|ug|uk|ur|uz|ve|vi|vo|wa|wo|xh|yi|yo|za|zh|zu)[%delimiter%]" },
                    { 5, "YEAR", "Allow current year only", null, "Current year only", "[%delimiter%](%current_year%)[%delimiter%]" },
                    { 6, "INTERNAL", "Describes if released for internal purpose", null, "Internal", "([%delimiter%](INT|INTERNAL)[%delimiter%])" },
                    { 7, "MAX CDS", "less or equal to 3 CDs", null, "3 Max CDs", "[-\\(](([4-9])|([1-9][0-9])+)CDS?[-\\)]" },
                    { 18, "SOURCES", "Demo regex", null, "DEMO", "[%delimiter%](demo)[%delimiter%]" },
                    { 8, "SAFE_GROUPS", "contains mp3 safe groups", null, "Mp3 safe groups", "[-](TSP|SIQ|GNVR|ROD|AGD|B2R|ALPMP3|WLM|CR|AGW|MUJI|ENTiTLED)" },
                    { 10, "SOURCES", "Bootleg regex", null, "BOOTLEG", "[%delimiter%](bootleg)[%delimiter%]" },
                    { 11, "SOURCES", "DVD regex", null, "DVD", "[%delimiter%](dvd)[%delimiter%]" },
                    { 12, "SOURCES", "Homemade regex", null, "HOMEMADE", "[%delimiter%](Homemade)[%delimiter%]" },
                    { 13, "SOURCES", "Magazing regex", null, "MAG", "[%delimiter%](mag|magazine)[%delimiter%]" },
                    { 14, "SOURCES", "Sampler regex", null, "SAMPLER", "[%delimiter%](Sampler)[%delimiter%]" },
                    { 15, "SOURCES", "TV regex", null, "TV", "[%delimiter%](tv)[%delimiter%]" },
                    { 36, "SOURCES", "FM regex", null, "FM", "[%delimiter%](FM)[%delimiter%]" },
                    { 9, "SOURCES", "CD regex", null, "CD", "[%delimiter%](cd|retail|cdm)[%delimiter%]" },
                    { 37, "SOURCES", "SAT regex", null, "SAT", "[%delimiter%](SAT)[%delimiter%]" }
                });

            migrationBuilder.InsertData(
                table: "ComplexWordMap",
                columns: new[] { "WordId", "ComplexWordId" },
                values: new object[,]
                {
                    { 35, 1 },
                    { 36, 1 },
                    { 37, 1 }
                });

            migrationBuilder.InsertData(
                table: "IrcInfo",
                columns: new[] { "Id", "Bot", "Channel", "SiteId" },
                values: new object[,]
                {
                    { 1, "pf-bot", "pf-spam", 1 },
                    { 2, "PiEcE", "#puzzlefactory", 1 },
                    { 3, "bh-bot", "bh-spam", 2 },
                    { 4, "bh", "#biohazzard", 2 }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "Applicability", "ComplexWordId", "Description", "Name", "WordId" },
                values: new object[,]
                {
                    { 2, 1, 1, "Ban Live Resources", "Ban Live Resources", null },
                    { 6, 3, null, "Mp3 patterns", "Mp3 patterns", 1 },
                    { 4, 1, null, "Allow English Only", "Allow English Only", 2 },
                    { 5, 1, null, "Allow EN|NL Only", "Allow EN|NL Only", 3 },
                    { 3, 1, null, "Ban Internal Resources", "Ban Internal Resources", 6 },
                    { 1, 1, null, "Ban Web Resources", "Ban Web Resources", 17 }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "BubbleLevel", "CategoryId", "Delimiter", "Description", "IsEnabled", "Name", "PackageId", "RaceActivityInSeconds" },
                values: new object[] { 2, 0, 1, "-", "Flac Section", false, "Flac", 2, 600 });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "BubbleLevel", "CategoryId", "Delimiter", "Description", "IsEnabled", "Name", "PackageId", "RaceActivityInSeconds" },
                values: new object[] { 1, 0, 1, "-", "Mp3 Section", false, "Mp3", 1, 600 });

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
