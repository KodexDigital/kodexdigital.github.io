using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp.Resume.My.Migrations
{
    public partial class auth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "LoginTime", "PasswordKey", "Username" },
                values: new object[] { new Guid("855a90de-1426-48d0-bf47-d195a2682520"), new DateTime(2021, 5, 4, 18, 11, 40, 469, DateTimeKind.Local).AddTicks(2362), "$2a$11$tVrPQnIQlnoMNp/4bcnUUubfJFEt6xjZz2d1kV8yttjn4q5DHBhj2", "kodex" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
