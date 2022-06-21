using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class _correcaoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Turmas",
                table: "Funcionarios");

            migrationBuilder.RenameColumn(
                name: "ResponsavelId",
                table: "Alunos",
                newName: "ResponsavelId1");

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId1",
                table: "Turmas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Adminstradores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_FuncionarioId1",
                table: "Turmas",
                column: "FuncionarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ResponsavelId1",
                table: "Alunos",
                column: "ResponsavelId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Responsaveis_ResponsavelId1",
                table: "Alunos",
                column: "ResponsavelId1",
                principalTable: "Responsaveis",
                principalColumn: "ResponsavelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Turmas_Funcionarios_FuncionarioId1",
                table: "Turmas",
                column: "FuncionarioId1",
                principalTable: "Funcionarios",
                principalColumn: "FuncionarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Responsaveis_ResponsavelId1",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Turmas_Funcionarios_FuncionarioId1",
                table: "Turmas");

            migrationBuilder.DropIndex(
                name: "IX_Turmas_FuncionarioId1",
                table: "Turmas");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_ResponsavelId1",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "FuncionarioId1",
                table: "Turmas");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Adminstradores");

            migrationBuilder.RenameColumn(
                name: "ResponsavelId1",
                table: "Alunos",
                newName: "ResponsavelId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Funcionarios",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Turmas",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Alunos",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Alunos",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
