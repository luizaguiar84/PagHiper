using Microsoft.EntityFrameworkCore.Migrations;

namespace Paghiper.Infra.Sqlite.Migrations
{
    public partial class Adicionado_campo_CEP_Endereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Endereco",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Endereco");
        }
    }
}
