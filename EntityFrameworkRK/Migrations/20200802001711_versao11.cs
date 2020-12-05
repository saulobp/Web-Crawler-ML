using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRK.Migrations
{
    public partial class versao11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Caracteristicas",
                table: "ProdutosML",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataExtracao",
                table: "ProdutosML",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "ProdutosML",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeProdutos",
                table: "ProdutosML",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Preco",
                table: "ProdutosML",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalVendas",
                table: "ProdutosML",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalVendasUltimos4",
                table: "ProdutosML",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Caracteristicas",
                table: "ProdutosML");

            migrationBuilder.DropColumn(
                name: "DataExtracao",
                table: "ProdutosML");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "ProdutosML");

            migrationBuilder.DropColumn(
                name: "NomeProdutos",
                table: "ProdutosML");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "ProdutosML");

            migrationBuilder.DropColumn(
                name: "TotalVendas",
                table: "ProdutosML");

            migrationBuilder.DropColumn(
                name: "TotalVendasUltimos4",
                table: "ProdutosML");
        }
    }
}
