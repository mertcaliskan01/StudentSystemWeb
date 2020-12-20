using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSystemWeb.Data.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "ToplamOran2",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "ToplamOran1",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Toplam2",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Toplam1",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "KadınOran2",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "KadınOran1",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Kadın2",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Kadın1",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "ErkekOran2",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "ErkekOran1",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Erkek2",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Erkek1",
                table: "IssizlikOranlari",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "IssizlikOranlari",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "IssizlikOranlari");

            migrationBuilder.AlterColumn<string>(
                name: "ToplamOran2",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "ToplamOran1",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Toplam2",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Toplam1",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "KadınOran2",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "KadınOran1",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Kadın2",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Kadın1",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ErkekOran2",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "ErkekOran1",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Erkek2",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Erkek1",
                table: "IssizlikOranlari",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
