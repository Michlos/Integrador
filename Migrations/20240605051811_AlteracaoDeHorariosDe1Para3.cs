using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrador.Migrations
{
    public partial class AlteracaoDeHorariosDe1Para3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoraExecucao",
                table: "OnBloxConfigure");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraExecucao01",
                table: "OnBloxConfigure",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraExecucao02",
                table: "OnBloxConfigure",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraExecucao03",
                table: "OnBloxConfigure",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoraExecucao01",
                table: "OnBloxConfigure");

            migrationBuilder.DropColumn(
                name: "HoraExecucao02",
                table: "OnBloxConfigure");

            migrationBuilder.DropColumn(
                name: "HoraExecucao03",
                table: "OnBloxConfigure");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraExecucao",
                table: "OnBloxConfigure",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
