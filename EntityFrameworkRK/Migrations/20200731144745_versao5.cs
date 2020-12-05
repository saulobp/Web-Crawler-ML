using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRK.Migrations
{
    public partial class versao5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaginacaoML",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    CategoriaMLId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaginacaoML", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaginacaoML_CategoriasMl_CategoriaMLId",
                        column: x => x.CategoriaMLId,
                        principalTable: "CategoriasMl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaginacaoML_CategoriaMLId",
                table: "PaginacaoML",
                column: "CategoriaMLId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaginacaoML");
        }
    }
}
