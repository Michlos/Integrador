using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrador.Migrations
{
    public partial class Correcao_Nome_da_tabela_EmailModel_para_Email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailModel",
                table: "EmailModel");

            migrationBuilder.RenameTable(
                name: "EmailModel",
                newName: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Email",
                table: "Email",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Email",
                table: "Email");

            migrationBuilder.RenameTable(
                name: "Email",
                newName: "EmailModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailModel",
                table: "EmailModel",
                column: "Id");
        }
    }
}
