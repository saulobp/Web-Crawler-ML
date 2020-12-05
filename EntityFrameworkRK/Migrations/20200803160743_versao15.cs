using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRK.Migrations
{
    public partial class versao15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaComum",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CategoriaOberloId = table.Column<Guid>(nullable: false),
                    CategoriaMercadoLivreId = table.Column<Guid>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaComum");
        }
    }
}
