using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRK.Migrations
{
    public partial class versao3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoriaMLId",
                table: "Categorias",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoriasMl",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CodigoSite = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    XPath = table.Column<string>(nullable: true),
                    IsPai = table.Column<bool>(nullable: false),
                    CategoriaId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasMl", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_CategoriasMl_CategoriaMLId",
                table: "Categorias");

            migrationBuilder.DropTable(
                name: "CategoriasMl");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_CategoriaMLId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CategoriaMLId",
                table: "Categorias");
        }
    }
}
