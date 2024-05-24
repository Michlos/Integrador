﻿// <auto-generated />
using System;
using Integrador.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Integrador.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Integrador.Domain.Cliente.ClienteModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cep")
                        .HasColumnType("int");

                    b.Property<string>("cgc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fantasia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("integracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("integrado")
                        .HasColumnType("bit");

                    b.Property<string>("logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tpDoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

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

                    b.Property<string>("IdEmailBox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Integrado")
                        .HasColumnType("bit");

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

                    b.Property<string>("AssuntoEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("CaixaDeEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

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

                    b.Property<string>("FinalRelatorio")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("InicioRelatorio")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PastaTemporaria")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

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

                    b.Property<string>("TagExtracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("EmailConfigure");
                });

            modelBuilder.Entity("Integrador.Domain.OnBloxConfigure.OnBloxConfigureModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BateladaIntegra")
                        .HasColumnType("bit");

                    b.Property<string>("BateladaLocalArquivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClienteAssuntoEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ClienteIntegra")
                        .HasColumnType("bit");

                    b.Property<int>("ClienteURIPorta")
                        .HasColumnType("int");

                    b.Property<string>("ClienteURIPost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ClienteUlimoIdIntegrado")
                        .HasColumnType("bigint");

                    b.Property<TimeSpan>("HoraExecucao")
                        .HasColumnType("time");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OnBloxConfigure");
                });
#pragma warning restore 612, 618
        }
    }
}
