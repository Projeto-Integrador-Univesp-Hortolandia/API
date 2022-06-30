using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace univesp_webapi.Migrations
{
    public partial class _tabelaProfessor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TurmaId",
                table: "Professores");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNasc",
                table: "Professores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Registro",
                table: "Professores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "cpf",
                table: "Professores",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNasc",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Registro",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "cpf",
                table: "Professores");

            migrationBuilder.AddColumn<int>(
                name: "TurmaId",
                table: "Professores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
