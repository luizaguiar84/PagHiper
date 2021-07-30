using Microsoft.EntityFrameworkCore.Migrations;

namespace PagHiper.Infra.MySql.Migrations
{
    public partial class teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Aluno_AlunoId",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "AlunoEndereco");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_AlunoId",
                table: "AlunoEndereco",
                newName: "IX_AlunoEndereco_AlunoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlunoEndereco",
                table: "AlunoEndereco",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlunoEndereco_Aluno_AlunoId",
                table: "AlunoEndereco",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlunoEndereco_Aluno_AlunoId",
                table: "AlunoEndereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlunoEndereco",
                table: "AlunoEndereco");

            migrationBuilder.RenameTable(
                name: "AlunoEndereco",
                newName: "Endereco");

            migrationBuilder.RenameIndex(
                name: "IX_AlunoEndereco_AlunoId",
                table: "Endereco",
                newName: "IX_Endereco_AlunoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Aluno_AlunoId",
                table: "Endereco",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
