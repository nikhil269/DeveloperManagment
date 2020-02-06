using Microsoft.EntityFrameworkCore.Migrations;

namespace developers.Migrations
{
    public partial class ChangeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FName",
                table: "DeveloperList");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "DeveloperList");

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "DeveloperList",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "DeveloperList",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firstName",
                table: "DeveloperList");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "DeveloperList");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "DeveloperList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "DeveloperList",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
