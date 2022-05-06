using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChannelTitle",
                table: "Youtube",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Youtube",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Youtube",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UploadedAt",
                table: "Youtube",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoId",
                table: "Youtube",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Views",
                table: "Youtube",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChannelTitle",
                table: "Youtube");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Youtube");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Youtube");

            migrationBuilder.DropColumn(
                name: "UploadedAt",
                table: "Youtube");

            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "Youtube");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "Youtube");
        }
    }
}
