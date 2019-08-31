using Microsoft.EntityFrameworkCore.Migrations;

namespace Boomerang.Context.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComplexWordMap",
                keyColumns: new[] { "WordId", "ComplexWordId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "ComplexWordMap",
                keyColumns: new[] { "WordId", "ComplexWordId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "ComplexWordMap",
                keyColumns: new[] { "WordId", "ComplexWordId" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PreDbs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PreDbs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ComplexWords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
