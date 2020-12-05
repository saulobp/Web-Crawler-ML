using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRK.Migrations
{
    public partial class versao9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoriaId",
                table: "ProdutosML",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosML_CategoriaId",
                table: "ProdutosML",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosML_Categorias_CategoriaId",
                table: "ProdutosML",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosML_Categorias_CategoriaId",
                table: "ProdutosML");

            migrationBuilder.DropIndex(
                name: "IX_ProdutosML_CategoriaId",
                table: "ProdutosML");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "ProdutosML");
        }
    }
}
