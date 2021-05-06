using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp.Resume.My.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SystemName = table.Column<string>(type: "TEXT", nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", nullable: true),
                    SystemOS = table.Column<string>(type: "TEXT", nullable: true),
                    IsLiked = table.Column<bool>(type: "INTEGER", nullable: false),
                    Counter = table.Column<long>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordKey = table.Column<string>(type: "TEXT", nullable: true),
                    LoginTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "LoginTime", "PasswordKey", "UserName" },
                values: new object[] { new Guid("993e0619-9e9e-4b19-b599-57b579fe2965"), new DateTime(2021, 5, 6, 13, 5, 23, 720, DateTimeKind.Local).AddTicks(3872), "$2a$11$Sx4/6PnA83L2SUomf8JQc.rz3XoVJdrFJubTO0DgejDulPQ0Zzu8m", "kodex" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
