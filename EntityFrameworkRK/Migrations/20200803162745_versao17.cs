using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRK.Migrations
{
    public partial class versao17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaComum");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoriaMercadoLivreId",
                table: "Categorias",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CategoriaComum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriaMercadoLivreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriaOberloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaComum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriaComum_CategoriasMl_CategoriaMercadoLivreId",
                        column: x => x.CategoriaMercadoLivreId,
                        principalTable: "CategoriasMl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaComum_Categorias_CategoriaOberloId",
                        column: x => x.CategoriaOberloId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaComum_CategoriaMercadoLivreId",
                table: "CategoriaComum",
                column: "CategoriaMercadoLivreId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaComum_CategoriaOberloId",
                table: "CategoriaComum",
                column: "CategoriaOberloId");
        }
    }
}
