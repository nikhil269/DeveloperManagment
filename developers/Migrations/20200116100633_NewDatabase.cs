using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace developers.Migrations
{
    public partial class NewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experience",
                table: "DeveloperList");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DeveloperList");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "DeveloperList");

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "DeveloperList",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "DeveloperList",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "DeveloperList",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "DeveloperList",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOB",
                table: "DeveloperList");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "DeveloperList");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "DeveloperList");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "DeveloperList");

            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "DeveloperList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DeveloperList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "DeveloperList",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
