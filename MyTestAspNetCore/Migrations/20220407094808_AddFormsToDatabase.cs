using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTestAspNetCore.Migrations
{
    public partial class AddFormsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormsM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    FormNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormsM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormsM_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormsM_OrganizationId",
                table: "FormsM",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormsM");
        }
    }
}
