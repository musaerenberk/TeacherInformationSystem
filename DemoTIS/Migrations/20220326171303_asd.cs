using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTIS.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HumanResourcesSpecialist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailAdress = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HumanResourcesSpecialist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
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
                    WorkingHour1 = table.Column<string>(nullable: true),
                    WorkingHour2 = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HumanResourcesSpecialist",
                columns: new[] { "Id", "MailAdress", "Password" },
                values: new object[] { 2, "humanr@gmail.com", "123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HumanResourcesSpecialist");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
