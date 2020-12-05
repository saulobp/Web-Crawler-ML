using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRK.Migrations
{
    public partial class versao18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_CategoriasMl_CategoriaMercadoLivreId",
                table: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_CategoriaMercadoLivreId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CategoriaMercadoLivreId",
                table: "Categorias");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoriaId",
                table: "CategoriasMl",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoriaMLId",
                table: "Categorias",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasMl_CategoriaId",
                table: "CategoriasMl",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasMl_Categorias_CategoriaId",
                table: "CategoriasMl",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasMl_Categorias_CategoriaId",
                table: "CategoriasMl");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasMl_CategoriaId",
                table: "CategoriasMl");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "CategoriasMl");

            migrationBuilder.DropColumn(
                name: "CategoriaMLId",
                table: "Categorias");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoriaMercadoLivreId",
                table: "Categorias",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_CategoriaMercadoLivreId",
                table: "Categorias",
                column: "CategoriaMercadoLivreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_CategoriasMl_CategoriaMercadoLivreId",
                table: "Categorias",
                column: "CategoriaMercadoLivreId",
                principalTable: "CategoriasMl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
