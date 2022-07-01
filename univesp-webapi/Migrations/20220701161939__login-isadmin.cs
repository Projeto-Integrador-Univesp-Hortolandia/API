using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace univesp_webapi.Migrations
{
    public partial class _loginisadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Responsavels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IsAdmin",
                table: "Responsavels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Responsavels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IsAdmin",
                table: "Professores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsAdmin",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Responsavels");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Responsavels");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Responsavels");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Funcionarios");
        }
    }
}
