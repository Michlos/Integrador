using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrador.Migrations
{
    public partial class Adicao_campos_extracao_dados_EmailConfigureModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FinalRelatorio",
                table: "EmailConfigure",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InicioRelatorio",
                table: "EmailConfigure",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PastaTemporaria",
                table: "EmailConfigure",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TagExtracao",
                table: "EmailConfigure",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalRelatorio",
                table: "EmailConfigure");

            migrationBuilder.DropColumn(
                name: "InicioRelatorio",
                table: "EmailConfigure");

            migrationBuilder.DropColumn(
                name: "PastaTemporaria",
                table: "EmailConfigure");

            migrationBuilder.DropColumn(
                name: "TagExtracao",
                table: "EmailConfigure");
        }
    }
}
