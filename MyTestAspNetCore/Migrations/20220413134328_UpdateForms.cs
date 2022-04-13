using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTestAspNetCore.Migrations
{
    public partial class UpdateForms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category12",
                table: "FormsM",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cod14",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cod2",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodOKPO10",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodOKPO15",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodPer20",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodPos19",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date11",
                table: "FormsM",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date18",
                table: "FormsM",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date3",
                table: "FormsM",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Kol8",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NSS13",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name21",
                table: "FormsM",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Number17",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Number23",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Number7",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberPP1",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberPassport4",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Radionuclid6",
                table: "FormsM",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SumActiv9",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type22",
                table: "FormsM",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type5",
                table: "FormsM",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vid16",
                table: "FormsM",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category12",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Cod14",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Cod2",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "CodOKPO10",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "CodOKPO15",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "CodPer20",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "CodPos19",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Date11",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Date18",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Date3",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Kol8",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "NSS13",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Name21",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Number17",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Number23",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Number7",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "NumberPP1",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "NumberPassport4",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Radionuclid6",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "SumActiv9",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Type22",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Type5",
                table: "FormsM");

            migrationBuilder.DropColumn(
                name: "Vid16",
                table: "FormsM");
        }
    }
}
