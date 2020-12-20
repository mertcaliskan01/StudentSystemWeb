using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSystemWeb.Data.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IssizlikOranlari",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Toplam1 = table.Column<string>(nullable: true),
                    Toplam2 = table.Column<string>(nullable: true),
                    Erkek1 = table.Column<string>(nullable: true),
                    Erkek2 = table.Column<string>(nullable: true),
                    Kadın1 = table.Column<string>(nullable: true),
                    Kadın2 = table.Column<string>(nullable: true),
                    ToplamOran1 = table.Column<string>(nullable: true),
                    ToplamOran2 = table.Column<string>(nullable: true),
                    ErkekOran1 = table.Column<string>(nullable: true),
                    ErkekOran2 = table.Column<string>(nullable: true),
                    KadınOran1 = table.Column<string>(nullable: true),
                    KadınOran2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssizlikOranlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Baslik = table.Column<string>(nullable: true),
                    IsAnaBaslik = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssizlikOranlari");

            migrationBuilder.DropTable(
                name: "Titles");
        }
    }
}
