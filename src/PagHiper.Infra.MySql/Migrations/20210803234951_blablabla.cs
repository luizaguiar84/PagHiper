using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PagHiper.Infra.MySql.Migrations
{
    public partial class blablabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataCadastro",
                table: "Aluno",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataCadastro",
                table: "Aluno",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTimeOffset));
        }
    }
}
