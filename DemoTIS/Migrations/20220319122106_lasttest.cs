using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTIS.Migrations
{
    public partial class lasttest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HumanResourcesSpecialists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailAdress = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HumanResourcesSpecialists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    MailAdress = table.Column<string>(nullable: true),
                    OfficeNo = table.Column<int>(nullable: false),
                    WorkingHour = table.Column<int>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HumanResourcesSpecialists",
                columns: new[] { "Id", "MailAdress", "Password" },
                values: new object[] { 2, "humanr@gmail.com", "123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HumanResourcesSpecialists");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
