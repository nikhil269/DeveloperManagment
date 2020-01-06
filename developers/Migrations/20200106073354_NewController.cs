using Microsoft.EntityFrameworkCore.Migrations;

namespace developers.Migrations
{
    public partial class NewController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DeveloperLists",
                table: "DeveloperLists");

            migrationBuilder.RenameTable(
                name: "DeveloperLists",
                newName: "DeveloperList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeveloperList",
                table: "DeveloperList",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DeveloperList",
                table: "DeveloperList");

            migrationBuilder.RenameTable(
                name: "DeveloperList",
                newName: "DeveloperLists");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeveloperLists",
                table: "DeveloperLists",
                column: "Id");
        }
    }
}
