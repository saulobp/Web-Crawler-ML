using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRK.Migrations
{
    public partial class versao10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosML_Categorias_CategoriaId",
                table: "ProdutosML");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosML_CategoriasMl_CategoriaId",
                table: "ProdutosML",
                column: "CategoriaId",
                principalTable: "CategoriasMl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosML_CategoriasMl_CategoriaId",
                table: "ProdutosML");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosML_Categorias_CategoriaId",
                table: "ProdutosML",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
