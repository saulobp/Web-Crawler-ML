﻿// <auto-generated />
using System;
using EntityFrameworkRK.BD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkRK.Migrations
{
    [DbContext(typeof(BDContext))]
    [Migration("20200803163322_versao18")]
    partial class versao18
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkRK.Model.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoriaMLId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoSite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPai")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("XPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("EntityFrameworkRK.Model.CategoriaML", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoSite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPai")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalProdutos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("XPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("CategoriasMl");
                });

            modelBuilder.Entity("EntityFrameworkRK.Model.PaginacaoML", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoriaMLId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaMLId");

                    b.ToTable("PaginacoesML");
                });

            modelBuilder.Entity("EntityFrameworkRK.Model.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Avaliacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoSite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataExtracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FornecedorLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FornecedorNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAliexpress")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecoHistorico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QtdImportacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QtdPedido30D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QtdPedido60D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QtdVisualizacaoShopify")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("EntityFrameworkRK.Model.ProdutoML", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Caracteristicas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataExtracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("NomeProdutos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalVendas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalVendasUltimos4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("ProdutosML");
                });

            modelBuilder.Entity("EntityFrameworkRK.Model.Categoria", b =>
                {
                    b.HasOne("EntityFrameworkRK.Model.Categoria", null)
                        .WithMany("Categorias")
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("EntityFrameworkRK.Model.CategoriaML", b =>
                {
                    b.HasOne("EntityFrameworkRK.Model.Categoria", null)
                        .WithMany("CategoriaMLs")
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("EntityFrameworkRK.Model.PaginacaoML", b =>
                {
                    b.HasOne("EntityFrameworkRK.Model.CategoriaML", null)
                        .WithMany("Paginacoes")
                        .HasForeignKey("CategoriaMLId");
                });

            modelBuilder.Entity("EntityFrameworkRK.Model.Produto", b =>
                {
                    b.HasOne("EntityFrameworkRK.Model.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFrameworkRK.Model.ProdutoML", b =>
                {
                    b.HasOne("EntityFrameworkRK.Model.CategoriaML", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });
#pragma warning restore 612, 618
        }
    }
}
