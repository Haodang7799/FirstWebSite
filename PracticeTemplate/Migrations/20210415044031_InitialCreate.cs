using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeTemplate.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loginUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loginUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "salaryTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    Office = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salaryTables", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "loginUsers",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "123", "user1" },
                    { 2, "123", "user2" },
                    { 3, "123", "user3" },
                    { 4, "123", "user4" }
                });

            migrationBuilder.InsertData(
                table: "salaryTables",
                columns: new[] { "Id", "Age", "Name", "Office", "Position", "Salary", "Start" },
                values: new object[,]
                {
                    { 1, 61, "Tiger Nixon", "Edinburgh", "System Architect", 320800m, new DateTime(2011, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 61, "Tiger Nixon", "Edinburgh", "System Architect", 0m, new DateTime(2011, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 61, "Tiger Nixon", "Edinburgh", "System Architect", 320800m, new DateTime(2011, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 61, "Tiger Nixon", "Edinburgh", "System Architect", 320800m, new DateTime(2011, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "loginUsers");

            migrationBuilder.DropTable(
                name: "salaryTables");
        }
    }
}
