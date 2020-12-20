using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSystemWeb.Data.Migrations
{
    public partial class migration9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TabloId",
                table: "IssizlikOraniTablo1",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TabloId",
                table: "IssizlikOraniTablo1");
        }
    }
}
