using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTIS.Migrations
{
    public partial class YeniDemoTs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MailAdress",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OfficeNo",
                table: "Teachers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkingHour",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "MailAdress",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "OfficeNo",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "WorkingHour",
                table: "Teachers");
        }
    }
}
