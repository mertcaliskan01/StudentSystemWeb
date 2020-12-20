using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSystemWeb.Data.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnaBaslikId",
                table: "Titles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnaBaslikId",
                table: "Titles");
        }
    }
}
