using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRK.Migrations
{
    public partial class versao6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaginacaoML_CategoriasMl_CategoriaMLId",
                table: "PaginacaoML");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaginacaoML",
                table: "PaginacaoML");

            migrationBuilder.RenameTable(
                name: "PaginacaoML",
                newName: "PaginacoesML");

            migrationBuilder.RenameIndex(
                name: "IX_PaginacaoML_CategoriaMLId",
                table: "PaginacoesML",
                newName: "IX_PaginacoesML_CategoriaMLId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaginacoesML",
                table: "PaginacoesML",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaginacoesML_CategoriasMl_CategoriaMLId",
                table: "PaginacoesML",
                column: "CategoriaMLId",
                principalTable: "CategoriasMl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaginacoesML_CategoriasMl_CategoriaMLId",
                table: "PaginacoesML");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaginacoesML",
                table: "PaginacoesML");

            migrationBuilder.RenameTable(
                name: "PaginacoesML",
                newName: "PaginacaoML");

            migrationBuilder.RenameIndex(
                name: "IX_PaginacoesML_CategoriaMLId",
                table: "PaginacaoML",
                newName: "IX_PaginacaoML_CategoriaMLId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaginacaoML",
                table: "PaginacaoML",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaginacaoML_CategoriasMl_CategoriaMLId",
                table: "PaginacaoML",
                column: "CategoriaMLId",
                principalTable: "CategoriasMl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
