using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp.Resume.My.Migrations
{
    public partial class NewFeilds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SystemName",
                table: "Likes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemOS",
                table: "Likes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SystemName",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "SystemOS",
                table: "Likes");
        }
    }
}
