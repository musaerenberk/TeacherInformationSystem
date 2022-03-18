using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTIS.Migrations
{
    public partial class SecondCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Teachers");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
