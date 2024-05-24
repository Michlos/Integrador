using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrador.Migrations
{
    public partial class AdicionandoUltimoIdIntegradoinOnBloxConfigure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ClienteUlimoIdIntegrado",
                table: "OnBloxConfigure",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteUlimoIdIntegrado",
                table: "OnBloxConfigure");
        }
    }
}
