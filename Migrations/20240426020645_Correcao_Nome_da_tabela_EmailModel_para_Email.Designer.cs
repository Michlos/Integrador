﻿// <auto-generated />
using System;
using Integrador.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Integrador.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240426020645_Correcao_Nome_da_tabela_EmailModel_para_Email")]
    partial class Correcao_Nome_da_tabela_EmailModel_para_Email
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Integrador.Domain.Email.EmailModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assunto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConteudoHtml")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConteudoTxt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DataDeRecebimento")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Remetente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("Integrador.Domain.EmailConfigure.EmailConfigureModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("EntradaPorta")
                        .HasColumnType("int");

                    b.Property<string>("EntradaServer")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int>("SmtpPorta")
                        .HasColumnType("int");

                    b.Property<string>("SmtpServer")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("SslEntradaHabilitado")
                        .HasColumnType("bit");

                    b.Property<bool>("SslSaidaHabilitado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("EmailConfigure");
                });
#pragma warning restore 612, 618
        }
    }
}
