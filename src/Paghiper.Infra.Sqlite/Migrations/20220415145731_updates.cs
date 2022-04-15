using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Paghiper.Infra.Sqlite.Migrations
{
    public partial class updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Boleto_BoletoOrderId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_BoletoOrderId",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boleto",
                table: "Boleto");

            migrationBuilder.DropColumn(
                name: "BoletoOrderId",
                table: "Item");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Turma",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Item",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "BoletoId",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ItemId",
                table: "Item",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "Endereco",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Endereco",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Boleto",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "Boleto",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "EarlyPaymentDiscountsCents",
                table: "Boleto",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EarlyPaymentDiscountsDays",
                table: "Boleto",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LatePaymentFine",
                table: "Boleto",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpenAfterDayDue",
                table: "Boleto",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartnersId",
                table: "Boleto",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PerDayInterest",
                table: "Boleto",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SellerDescription",
                table: "Boleto",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TurmaId",
                table: "AlunoTurma",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "AlunoTurma",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AlunoTurma",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "AlunoParcelas",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AlunoParcelas",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "AlunoMatricula",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AlunoMatricula",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "AlunoContato",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AlunoContato",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<bool>(
                name: "StatusFinanceiro",
                table: "Aluno",
                nullable: false,
                oldClrType: typeof(char),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<bool>(
                name: "StatusCadastro",
                table: "Aluno",
                nullable: false,
                oldClrType: typeof(char),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataCadastro",
                table: "Aluno",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Aluno",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boleto",
                table: "Boleto",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Lead",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    AceitaPropaganda = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Telefone = table.Column<string>(maxLength: 14, nullable: false),
                    Cupom = table.Column<string>(maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lead", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_BoletoId",
                table: "Item",
                column: "BoletoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Boleto_BoletoId",
                table: "Item",
                column: "BoletoId",
                principalTable: "Boleto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Boleto_BoletoId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Lead");

            migrationBuilder.DropIndex(
                name: "IX_Item_BoletoId",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boleto",
                table: "Boleto");

            migrationBuilder.DropColumn(
                name: "BoletoId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "EarlyPaymentDiscountsCents",
                table: "Boleto");

            migrationBuilder.DropColumn(
                name: "EarlyPaymentDiscountsDays",
                table: "Boleto");

            migrationBuilder.DropColumn(
                name: "LatePaymentFine",
                table: "Boleto");

            migrationBuilder.DropColumn(
                name: "OpenAfterDayDue",
                table: "Boleto");

            migrationBuilder.DropColumn(
                name: "PartnersId",
                table: "Boleto");

            migrationBuilder.DropColumn(
                name: "PerDayInterest",
                table: "Boleto");

            migrationBuilder.DropColumn(
                name: "SellerDescription",
                table: "Boleto");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Turma",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Item",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "BoletoOrderId",
                table: "Item",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AlunoId",
                table: "Endereco",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Endereco",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "Boleto",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Boleto",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "TurmaId",
                table: "AlunoTurma",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AlunoId",
                table: "AlunoTurma",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "AlunoTurma",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AlunoId",
                table: "AlunoParcelas",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "AlunoParcelas",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AlunoId",
                table: "AlunoMatricula",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "AlunoMatricula",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AlunoId",
                table: "AlunoContato",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "AlunoContato",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<char>(
                name: "StatusFinanceiro",
                table: "Aluno",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<char>(
                name: "StatusCadastro",
                table: "Aluno",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataCadastro",
                table: "Aluno",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Aluno",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boleto",
                table: "Boleto",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_BoletoOrderId",
                table: "Item",
                column: "BoletoOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Boleto_BoletoOrderId",
                table: "Item",
                column: "BoletoOrderId",
                principalTable: "Boleto",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
