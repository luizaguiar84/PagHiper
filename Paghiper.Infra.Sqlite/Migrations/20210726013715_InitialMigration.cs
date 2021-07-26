using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Paghiper.Infra.Sqlite.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cpf = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: true),
                    ResponsavelNome = table.Column<string>(nullable: true),
                    ResponsavelCpf = table.Column<string>(nullable: true),
                    ResponsavelParentesco = table.Column<string>(nullable: true),
                    ResponsavelTelefone = table.Column<string>(nullable: true),
                    StatusCadastro = table.Column<char>(nullable: false),
                    StatusFinanceiro = table.Column<char>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boletos",
                columns: table => new
                {
                    OrderId = table.Column<string>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    ApiKey = table.Column<string>(nullable: true),
                    PayerEmail = table.Column<string>(nullable: true),
                    PayerName = table.Column<string>(nullable: true),
                    PayerCpfCnpj = table.Column<string>(nullable: true),
                    PayerPhone = table.Column<string>(nullable: true),
                    PayerStreet = table.Column<string>(nullable: true),
                    PayerNumber = table.Column<string>(nullable: true),
                    PayerComplement = table.Column<string>(nullable: true),
                    PayerDistrict = table.Column<string>(nullable: true),
                    PayerCity = table.Column<string>(nullable: true),
                    PayerState = table.Column<string>(nullable: true),
                    PayerZipCode = table.Column<string>(nullable: true),
                    NotificationUrl = table.Column<string>(nullable: true),
                    DiscountCents = table.Column<string>(nullable: true),
                    ShippingPriceCents = table.Column<string>(nullable: true),
                    ShippingMethods = table.Column<string>(nullable: true),
                    FixedDescription = table.Column<bool>(nullable: false),
                    DaysDueDate = table.Column<string>(nullable: true),
                    TypeBankSlip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletos", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlunoContato",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AlunoId = table.Column<Guid>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoContato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunoContato_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoMatricula",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AlunoId = table.Column<Guid>(nullable: false),
                    NumeroRegistro = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    PagamentoTipoId = table.Column<string>(nullable: true),
                    PagamentoId = table.Column<string>(nullable: true),
                    CursoId = table.Column<string>(nullable: true),
                    DataMatricula = table.Column<DateTime>(nullable: true),
                    CampanhaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoMatricula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunoMatricula_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoParcelas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AlunoId = table.Column<Guid>(nullable: false),
                    TipoPagamentoId = table.Column<string>(nullable: true),
                    DataVencimento = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    PagamentoEfetuadoId = table.Column<string>(nullable: true),
                    PagamentoEfetuado = table.Column<string>(nullable: true),
                    DataPagamentoEfetuado = table.Column<DateTime>(nullable: true),
                    ValorEfetuado = table.Column<decimal>(nullable: false),
                    NumeroParcelas = table.Column<int>(nullable: false),
                    NumeroTotalParcelas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoParcelas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunoParcelas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AlunoId = table.Column<Guid>(nullable: false),
                    Rua = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    PriceCents = table.Column<string>(nullable: true),
                    BoletoOrderId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Boletos_BoletoOrderId",
                        column: x => x.BoletoOrderId,
                        principalTable: "Boletos",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlunoTurma",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataIngresso = table.Column<DateTime>(nullable: false),
                    TurmaId = table.Column<Guid>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    AlunoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoTurma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunoTurma_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlunoTurma_Turma_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoContato_AlunoId",
                table: "AlunoContato",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoMatricula_AlunoId",
                table: "AlunoMatricula",
                column: "AlunoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AlunoParcelas_AlunoId",
                table: "AlunoParcelas",
                column: "AlunoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AlunoTurma_AlunoId",
                table: "AlunoTurma",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoTurma_TurmaId",
                table: "AlunoTurma",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_AlunoId",
                table: "Endereco",
                column: "AlunoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_BoletoOrderId",
                table: "Item",
                column: "BoletoOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoContato");

            migrationBuilder.DropTable(
                name: "AlunoMatricula");

            migrationBuilder.DropTable(
                name: "AlunoParcelas");

            migrationBuilder.DropTable(
                name: "AlunoTurma");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Boletos");
        }
    }
}
