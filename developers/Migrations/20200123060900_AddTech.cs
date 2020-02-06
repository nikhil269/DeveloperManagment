using Microsoft.EntityFrameworkCore.Migrations;

namespace developers.Migrations
{
    public partial class AddTech : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TechModel",
                columns: table => new
                {
                    item_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    item_text = table.Column<string>(nullable: true),
                    DeveloperListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechModel", x => x.item_id);
                    table.ForeignKey(
                        name: "FK_TechModel_DeveloperList_DeveloperListId",
                        column: x => x.DeveloperListId,
                        principalTable: "DeveloperList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TechModel_DeveloperListId",
                table: "TechModel",
                column: "DeveloperListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TechModel");
        }
    }
}
