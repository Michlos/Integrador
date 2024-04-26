using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrador.Migrations
{
    public partial class Inclusao_EmailModel_Receber_Emails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Remetente = table.Column<string>(nullable: true),
                    Assunto = table.Column<string>(nullable: true),
                    DataDeRecebimento = table.Column<DateTimeOffset>(nullable: false),
                    ConteudoTxt = table.Column<string>(nullable: true),
                    ConteudoHtml = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailModel");
        }
    }
}
