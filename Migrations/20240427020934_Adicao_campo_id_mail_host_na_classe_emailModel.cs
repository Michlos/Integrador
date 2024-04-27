using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrador.Migrations
{
    public partial class Adicao_campo_id_mail_host_na_classe_emailModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdEmailBox",
                table: "Email",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Integrado",
                table: "Email",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEmailBox",
                table: "Email");

            migrationBuilder.DropColumn(
                name: "Integrado",
                table: "Email");
        }
    }
}
