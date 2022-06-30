using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace univesp_webapi.Migrations
{
    public partial class _post : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Postagem",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "hasAlert",
                table: "Posts",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hasAlert",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "Postagem",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
