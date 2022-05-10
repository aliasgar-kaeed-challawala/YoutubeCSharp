using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class finalupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "bQY07sHbF2w",
                column: "ImageUrl",
                value: "https://i.ytimg.com/vi/bQY07sHbF2w/hqdefault.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "dwapUG-XFKs",
                column: "ImageUrl",
                value: "https://i.ytimg.com/vi/dwapUG-XFKs/hqdefault.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "VCJZVtKIwrU",
                column: "ImageUrl",
                value: "https://i.ytimg.com/vi/VCJZVtKIwrU/hqdefault.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "vXIAB_1FEC0",
                column: "ImageUrl",
                value: "https://i.ytimg.com/vi/vXIAB_1FEC0/hqdefault.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "Y2Oj9gllHno",
                column: "ImageUrl",
                value: "https://i.ytimg.com/vi/Y2Oj9gllHno/hqdefault.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "yoigsHYc77s",
                column: "ImageUrl",
                value: "https://i.ytimg.com/vi/yoigsHYc77s/hqdefault.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "ZQ4E0JJcxz0",
                column: "ImageUrl",
                value: "https://i.ytimg.com/vi/ZQ4E0JJcxz0/hqdefault.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "bQY07sHbF2w",
                column: "ImageUrl",
                value: "https://i.ytimg.com/an_webp/bQY07sHbF2w/mqdefault_6s.webp?du=3000&sqp=CNDy45MG&rs=AOn4CLDGFhdftIkPhVfwiw5abcCYC1TrGg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "dwapUG-XFKs",
                column: "ImageUrl",
                value: "https://i.ytimg.com/an_webp/dwapUG-XFKs/mqdefault_6s.webp?du=3000&sqp=CLbK45MG&rs=AOn4CLDnmPuZ-mxk0f8dk6QgDmNxNnqqpw");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "VCJZVtKIwrU",
                column: "ImageUrl",
                value: "https://i.ytimg.com/an_webp/VCJZVtKIwrU/mqdefault_6s.webp?du=3000&sqp=CPGL5JMG&rs=AOn4CLCmdG7yWfWpFenjjSYCRbmNlE40Dg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "vXIAB_1FEC0",
                column: "ImageUrl",
                value: "https://i.ytimg.com/an_webp/vXIAB_1FEC0/mqdefault_6s.webp?du=3000&sqp=CI-I5JMG&rs=AOn4CLDFLGrltM2MHWaWsI2NlGaCYLQORg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "Y2Oj9gllHno",
                column: "ImageUrl",
                value: "https://i.ytimg.com/vi/Y2Oj9gllHno/hqdefault.jpg?sqp=-oaymwEcCOADEI4CSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLDNsiucDjYGTBJqLj4o_3DztII1DA");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "yoigsHYc77s",
                column: "ImageUrl",
                value: "https://i.ytimg.com/an_webp/yoigsHYc77s/mqdefault_6s.webp?du=3000&sqp=CJX145MG&rs=AOn4CLAM3oTGAdO5HlrygRYrGMPUkh3QaA");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: "ZQ4E0JJcxz0",
                column: "ImageUrl",
                value: "https://i.ytimg.com/an_webp/ZQ4E0JJcxz0/mqdefault_6s.webp?du=3000&sqp=CLvx45MG&rs=AOn4CLDfQBMcU_wo27tbM70zq8qQRfN2wQ");
        }
    }
}
