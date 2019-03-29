﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Repositorio.AcessoBanco.Contextos;
using System;

namespace Repositorio.AcessoBanco.Migrations
{
    [DbContext(typeof(ContextoAcessoBanco))]
    [Migration("20190329154518_Migracao_Inicial")]
    partial class Migracao_Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repositorio.AcessoBanco.Entidades.Jogador", b =>
                {
                    b.Property<int>("JogadorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("JogadorId");

                    b.ToTable("Jogadores");
                });
#pragma warning restore 612, 618
        }
    }
}
