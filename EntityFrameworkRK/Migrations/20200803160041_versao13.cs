using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRK.Migrations
{
    public partial class versao13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_CategoriasMl_CategoriaMLId",
                table: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_CategoriaMLId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "CategoriasMl");

            migrationBuilder.DropColumn(
                name: "CategoriaMLId",
                table: "Categorias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoriaId",
                table: "CategoriasMl",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoriaMLId",
                table: "Categorias",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_CategoriaMLId",
                table: "Categorias",
                column: "CategoriaMLId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_CategoriasMl_CategoriaMLId",
                table: "Categorias",
                column: "CategoriaMLId",
                principalTable: "CategoriasMl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
