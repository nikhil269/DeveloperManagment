using Microsoft.EntityFrameworkCore.Migrations;

namespace developers.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeveloperLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Technology = table.Column<string>(nullable: true),
                    Experience = table.Column<int>(nullable: false),
                    GithubLink = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Add1 = table.Column<string>(nullable: true),
                    Add2 = table.Column<string>(nullable: true),
                    Mobile = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeveloperLists", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeveloperLists");
        }
    }
}
