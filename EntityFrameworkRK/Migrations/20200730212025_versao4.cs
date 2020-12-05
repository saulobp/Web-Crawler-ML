using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRK.Migrations
{
    public partial class versao4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TotalProdutos",
                table: "CategoriasMl",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "CategoriasMl",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalProdutos",
                table: "CategoriasMl");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "CategoriasMl");
        }
    }
}
