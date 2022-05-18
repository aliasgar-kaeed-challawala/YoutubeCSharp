using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    ProfileImg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Youtube",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VideoId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    ChannelTitle = table.Column<string>(nullable: true),
                    Views = table.Column<string>(nullable: true),
                    UploadedAt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Youtube", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    VideoId = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    Views = table.Column<string>(nullable: true),
                    Likes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.VideoId);
                    table.ForeignKey(
                        name: "FK_Videos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    HistoryId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    VideoId = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.HistoryId);
                    table.ForeignKey(
                        name: "FK_History_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_History_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "VideoId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    { "Y2Oj9gllHno", "https://i.ytimg.com/vi/Y2Oj9gllHno/hqdefault.jpg", "714K", "I am a Chef | Aakash Gupta | Stand-Up Comedy | Crowd Work", "1", "8,521,590" },
                    { "vXIAB_1FEC0", "https://i.ytimg.com/vi/vXIAB_1FEC0/hqdefault.jpg", "122K", "Galaxy S22 Ultra Review: Separating from the Pack!", "1", "3,578,675" },
                    { "dwapUG-XFKs", "https://i.ytimg.com/vi/dwapUG-XFKs/hqdefault.jpg", "1K", "Shell profits nearly triple as oil prices surge amid Russia-Ukraine war – BBC News", "2", "103,889" },
                    { "bQY07sHbF2w", "https://i.ytimg.com/vi/bQY07sHbF2w/hqdefault.jpg", "600", "Real Madrid to face Liverpool in Champions League final as comeback stuns Man City - BBC News", "2", "23,079" },
                    { "VCJZVtKIwrU", "https://i.ytimg.com/vi/VCJZVtKIwrU/hqdefault.jpg", "16K", "Russia's flagship warship the Moskva has sunk – BBC News", "2", "1,864,946" },
                    { "ZQ4E0JJcxz0", "https://i.ytimg.com/vi/ZQ4E0JJcxz0/hqdefault.jpg", "133K", "What Happens When the iPhone Peaks ? ", "3", "3,274,362" },
                    { "yoigsHYc77s", "https://i.ytimg.com/vi/yoigsHYc77s/hqdefault.jpg", "131K", "The Apple Studio Display is a Bad Deal", "3", "3,571,065" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_History_UserId",
                table: "History",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_History_VideoId",
                table: "History",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_UserId",
                table: "Videos",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Youtube");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
