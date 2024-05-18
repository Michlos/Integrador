using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrador.Migrations
{
    public partial class InclusaoOnBloxConfigure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OnBloxConfigure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    ClienteAssuntoEmail = table.Column<string>(nullable: true),
                    ClienteIntegra = table.Column<bool>(nullable: false),
                    ClienteURIPost = table.Column<string>(nullable: true),
                    ClienteURIPorta = table.Column<int>(nullable: false),
                    BateladaLocalArquivo = table.Column<string>(nullable: true),
                    BateladaIntegra = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnBloxConfigure", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OnBloxConfigure");
        }
    }
}
