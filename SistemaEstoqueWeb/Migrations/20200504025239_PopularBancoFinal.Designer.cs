﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaEstoqueWeb.Data;

namespace SistemaEstoqueWeb.Migrations
{
    [DbContext(typeof(SistemaEstoqueWebContext))]
    [Migration("20200504025239_PopularBancoFinal")]
    partial class PopularBancoFinal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaEstoqueWeb.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("NomeProduto");

                    b.Property<string>("NumeroSerie");

                    b.Property<double>("Preço");

                    b.Property<int>("Quantidade");

                    b.Property<int?>("UsuarioID");

                    b.HasKey("ProdutoID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("SistemaEstoqueWeb.Models.UsuarioCadastro", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<DateTime>("dataNascimento");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SistemaEstoqueWeb.Models.Produto", b =>
                {
                    b.HasOne("SistemaEstoqueWeb.Models.UsuarioCadastro", "UsuarioId")
                        .WithMany("Produtos")
                        .HasForeignKey("UsuarioID");
                });
#pragma warning restore 612, 618
        }
    }
}
