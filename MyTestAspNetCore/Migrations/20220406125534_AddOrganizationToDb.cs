using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTestAspNetCore.Migrations
{
    public partial class AddOrganizationToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganYprav = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegNumber = table.Column<int>(type: "int", nullable: false),
                    SubjectRF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YrName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortYrName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdrYr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaksOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OKPO = table.Column<int>(type: "int", nullable: false),
                    OKVED = table.Column<int>(type: "int", nullable: false),
                    OKOGY = table.Column<int>(type: "int", nullable: false),
                    OKTMO = table.Column<int>(type: "int", nullable: false),
                    INN = table.Column<int>(type: "int", nullable: false),
                    KPP = table.Column<int>(type: "int", nullable: false),
                    OKOPF = table.Column<int>(type: "int", nullable: false),
                    OKFS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
