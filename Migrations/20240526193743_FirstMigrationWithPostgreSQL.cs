using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Integrador.Migrations
{
    public partial class FirstMigrationWithPostgreSQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdOnBlox = table.Column<long>(nullable: false),
                    nome = table.Column<string>(nullable: true),
                    codigo = table.Column<string>(nullable: true),
                    integracao = table.Column<string>(nullable: true),
                    tpDoc = table.Column<string>(nullable: true),
                    cgc = table.Column<string>(nullable: true),
                    fantasia = table.Column<string>(nullable: true),
                    fone = table.Column<string>(nullable: true),
                    cep = table.Column<int>(nullable: false),
                    logradouro = table.Column<string>(nullable: true),
                    numero = table.Column<string>(nullable: true),
                    bairro = table.Column<string>(nullable: true),
                    cidade = table.Column<string>(nullable: true),
                    uf = table.Column<string>(nullable: true),
                    integrado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdEmailBox = table.Column<string>(nullable: true),
                    Remetente = table.Column<string>(nullable: true),
                    Assunto = table.Column<string>(nullable: true),
                    DataDeRecebimento = table.Column<DateTimeOffset>(nullable: false),
                    ConteudoTxt = table.Column<string>(nullable: true),
                    ConteudoHtml = table.Column<string>(nullable: true),
                    Integrado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailConfigure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Senha = table.Column<string>(maxLength: 12, nullable: false),
                    SmtpServer = table.Column<string>(maxLength: 50, nullable: false),
                    SmtpPorta = table.Column<int>(nullable: false),
                    SslSaidaHabilitado = table.Column<bool>(nullable: false),
                    EntradaServer = table.Column<string>(maxLength: 50, nullable: false),
                    EntradaPorta = table.Column<int>(nullable: false),
                    SslEntradaHabilitado = table.Column<bool>(nullable: false),
                    CaixaDeEmail = table.Column<string>(maxLength: 10, nullable: false),
                    AssuntoEmail = table.Column<string>(maxLength: 300, nullable: false),
                    InicioRelatorio = table.Column<string>(maxLength: 50, nullable: false),
                    FinalRelatorio = table.Column<string>(maxLength: 50, nullable: false),
                    TagExtracao = table.Column<string>(maxLength: 10, nullable: false),
                    PastaTemporaria = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailConfigure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnBloxConfigure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Usuario = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    HoraExecucao = table.Column<TimeSpan>(nullable: false),
                    ClienteUlimoIdIntegrado = table.Column<long>(nullable: false),
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
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "EmailConfigure");

            migrationBuilder.DropTable(
                name: "OnBloxConfigure");
        }
    }
}
