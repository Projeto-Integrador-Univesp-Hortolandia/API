using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class _AlterTurma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Turmas",
                table: "Turmas");

            migrationBuilder.AlterColumn<int>(
                name: "TurmaId",
                table: "Turmas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Turmas",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Turmas",
                table: "Turmas",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Turmas",
                table: "Turmas");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Turmas");

            migrationBuilder.AlterColumn<int>(
                name: "TurmaId",
                table: "Turmas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Turmas",
                table: "Turmas",
                column: "TurmaId");
        }
    }
}
