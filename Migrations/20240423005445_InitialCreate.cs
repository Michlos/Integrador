using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrador.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailConfigure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Senha = table.Column<string>(maxLength: 12, nullable: false),
                    SmtpServer = table.Column<string>(maxLength: 50, nullable: false),
                    SmtpPorta = table.Column<int>(nullable: false),
                    SslSaidaHabilitado = table.Column<bool>(nullable: false),
                    EntradaServer = table.Column<string>(maxLength: 50, nullable: false),
                    EntradaPorta = table.Column<int>(nullable: false),
                    SslEntradaHabilitado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailConfigure", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailConfigure");
        }
    }
}
