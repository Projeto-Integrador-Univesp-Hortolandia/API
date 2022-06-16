using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class _AlteracaoTurma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Turmas");

            migrationBuilder.DropColumn(
                name: "TurmaId",
                table: "Turmas");

            migrationBuilder.RenameColumn(
                name: "NomeTurma",
                table: "Turmas",
                newName: "turma");

            migrationBuilder.AddColumn<string>(
                name: "Ano",
                table: "Turmas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Periodo",
                table: "Turmas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sala",
                table: "Turmas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Turmas");

            migrationBuilder.DropColumn(
                name: "Periodo",
                table: "Turmas");

            migrationBuilder.DropColumn(
                name: "Sala",
                table: "Turmas");

            migrationBuilder.RenameColumn(
                name: "turma",
                table: "Turmas",
                newName: "NomeTurma");

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Turmas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TurmaId",
                table: "Turmas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
