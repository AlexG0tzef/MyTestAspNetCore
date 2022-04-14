using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTestAspNetCore.Migrations
{
    public partial class updateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormsNumberMId",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FormsNumberM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationMId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormsNumberM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormsNumberM_Organizations_OrganizationMId",
                        column: x => x.OrganizationMId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormsM_FormsNumberMId",
                table: "FormsM",
                column: "FormsNumberMId");

            migrationBuilder.CreateIndex(
                name: "IX_FormsNumberM_OrganizationMId",
                table: "FormsNumberM",
                column: "OrganizationMId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormsM_FormsNumberM_FormsNumberMId",
                table: "FormsM",
                column: "FormsNumberMId",
                principalTable: "FormsNumberM",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormsM_FormsNumberM_FormsNumberMId",
                table: "FormsM");

            migrationBuilder.DropTable(
                name: "FormsNumberM");

            migrationBuilder.DropIndex(
                name: "IX_FormsM_FormsNumberMId",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "FormsNumberMId",
                table: "FormsM");
        }
    }
}
