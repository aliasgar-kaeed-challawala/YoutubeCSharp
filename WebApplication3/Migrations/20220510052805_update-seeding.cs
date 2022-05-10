using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class updateseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "ProfileImg", "UserName" },
                values: new object[] { "1", "aakashgupta@gmail.com", "https://yt3.ggpht.com/ytc/AKedOLSvPEUzOL_qQkQQd17lcsvj3ikeb2iEj92MUBi91A=s68-c-k-c0x00ffffff-no-rj", "Aakash Gupta" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "ProfileImg", "UserName" },
                values: new object[] { "2", "bbc@gmail.com", "https://yt3.ggpht.com/MRywaef1JLriHf-MUivy7-WAoVAL4sB7VHZXgmprXtmpOlN73I4wBhjjWdkZNFyJNiUP6MHm1w=s176-c-k-c0x00ffffff-no-rj", "BBC NEWS" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "ProfileImg", "UserName" },
                values: new object[] { "3", "mkbhd@gmail.com", "https://yt3.ggpht.com/lkH37D712tiyphnu0Id0D5MwwQ7IRuwgQLVD05iMXlDWO-kDHut3uI4MgIEAQ9StK0qOST7fiA=s176-c-k-c0x00ffffff-no-rj", "Marques Brownlee" });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "VideoId", "ImageUrl", "Likes", "Title", "UserId", "Views" },
                values: new object[,]
                {
                    { "Y2Oj9gllHno", "https://i.ytimg.com/vi/Y2Oj9gllHno/hqdefault.jpg?sqp=-oaymwEcCOADEI4CSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLDNsiucDjYGTBJqLj4o_3DztII1DA", "714K", "I am a Chef | Aakash Gupta | Stand-Up Comedy | Crowd Work", "1", "8,521,590" },
                    { "vXIAB_1FEC0", "https://i.ytimg.com/an_webp/vXIAB_1FEC0/mqdefault_6s.webp?du=3000&sqp=CI-I5JMG&rs=AOn4CLDFLGrltM2MHWaWsI2NlGaCYLQORg", "122K", "Galaxy S22 Ultra Review: Separating from the Pack!", "1", "3,578,675" },
                    { "dwapUG-XFKs", "https://i.ytimg.com/an_webp/dwapUG-XFKs/mqdefault_6s.webp?du=3000&sqp=CLbK45MG&rs=AOn4CLDnmPuZ-mxk0f8dk6QgDmNxNnqqpw", "1K", "Shell profits nearly triple as oil prices surge amid Russia-Ukraine war – BBC News", "2", "103,889" },
                    { "bQY07sHbF2w", "https://i.ytimg.com/an_webp/bQY07sHbF2w/mqdefault_6s.webp?du=3000&sqp=CNDy45MG&rs=AOn4CLDGFhdftIkPhVfwiw5abcCYC1TrGg", "600", "Real Madrid to face Liverpool in Champions League final as comeback stuns Man City - BBC News", "2", "23,079" },
                    { "VCJZVtKIwrU", "https://i.ytimg.com/an_webp/VCJZVtKIwrU/mqdefault_6s.webp?du=3000&sqp=CPGL5JMG&rs=AOn4CLCmdG7yWfWpFenjjSYCRbmNlE40Dg", "16K", "Russia's flagship warship the Moskva has sunk – BBC News", "2", "1,864,946" },
                    { "ZQ4E0JJcxz0", "https://i.ytimg.com/an_webp/ZQ4E0JJcxz0/mqdefault_6s.webp?du=3000&sqp=CLvx45MG&rs=AOn4CLDfQBMcU_wo27tbM70zq8qQRfN2wQ", "133K", "What Happens When the iPhone Peaks ? ", "3", "3,274,362" },
                    { "yoigsHYc77s", "https://i.ytimg.com/an_webp/yoigsHYc77s/mqdefault_6s.webp?du=3000&sqp=CJX145MG&rs=AOn4CLAM3oTGAdO5HlrygRYrGMPUkh3QaA", "131K", "The Apple Studio Display is a Bad Deal", "3", "3,571,065" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "bQY07sHbF2w");

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "dwapUG-XFKs");

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "VCJZVtKIwrU");

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "vXIAB_1FEC0");

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "Y2Oj9gllHno");

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "yoigsHYc77s");

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "ZQ4E0JJcxz0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "3");
        }
    }
}
