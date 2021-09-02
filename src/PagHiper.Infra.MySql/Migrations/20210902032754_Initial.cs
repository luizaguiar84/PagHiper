using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace PagHiper.Infra.MySql.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTimeOffset>(nullable: true),
                    DataCadastro = table.Column<DateTimeOffset>(nullable: false),
                    DataAtualizacao = table.Column<DateTimeOffset>(nullable: true),
                    ResponsavelNome = table.Column<string>(nullable: true),
                    ResponsavelCpf = table.Column<string>(nullable: true),
                    ResponsavelParentesco = table.Column<string>(nullable: true),
                    ResponsavelTelefone = table.Column<string>(nullable: true),
                    StatusCadastro = table.Column<bool>(nullable: false),
                    StatusFinanceiro = table.Column<bool>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boleto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    apiKey = table.Column<string>(nullable: true),
                    order_id = table.Column<string>(nullable: true),
                    payer_email = table.Column<string>(nullable: true),
                    payer_name = table.Column<string>(nullable: true),
                    payer_cpf_cnpj = table.Column<string>(nullable: true),
                    payer_phone = table.Column<string>(nullable: true),
                    payer_street = table.Column<string>(nullable: true),
                    payer_number = table.Column<string>(nullable: true),
                    payer_complement = table.Column<string>(nullable: true),
                    payer_district = table.Column<string>(nullable: true),
                    payer_city = table.Column<string>(nullable: true),
                    payer_state = table.Column<string>(nullable: true),
                    payer_zip_code = table.Column<string>(nullable: true),
                    notification_url = table.Column<string>(nullable: true),
                    discount_cents = table.Column<string>(nullable: true),
                    shipping_price_cents = table.Column<string>(nullable: true),
                    shipping_methods = table.Column<string>(nullable: true),
                    partners_id = table.Column<string>(nullable: true),
                    seller_description = table.Column<string>(nullable: true),
                    late_payment_fine = table.Column<string>(nullable: true),
                    per_day_interest = table.Column<string>(nullable: true),
                    early_payment_discounts_days = table.Column<string>(nullable: true),
                    early_payment_discounts_cents = table.Column<string>(nullable: true),
                    open_after_day_due = table.Column<string>(nullable: true),
                    fixed_description = table.Column<bool>(nullable: false),
                    days_due_date = table.Column<string>(nullable: true),
                    type_bank_slip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boleto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lead",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
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

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: true),
                    AlunoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoContato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunoContato_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoMatricula",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NumeroRegistro = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    PagamentoTipoId = table.Column<string>(nullable: true),
                    PagamentoId = table.Column<string>(nullable: true),
                    CursoId = table.Column<string>(nullable: true),
                    DataMatricula = table.Column<DateTimeOffset>(nullable: true),
                    CampanhaId = table.Column<string>(nullable: true),
                    AlunoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoMatricula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunoMatricula_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoParcelas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: false),
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
                        name: "FK_AlunoParcelas_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
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
                        name: "FK_Endereco_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BoletoId = table.Column<int>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    quantity = table.Column<string>(nullable: true),
                    item_id = table.Column<string>(nullable: true),
                    price_cents = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Boleto_BoletoId",
                        column: x => x.BoletoId,
                        principalTable: "Boleto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoTurma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DataIngresso = table.Column<DateTimeOffset>(nullable: false),
                    TurmaId = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    AlunoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoTurma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunoTurma_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Item_BoletoId",
                table: "Item",
                column: "BoletoId");
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
                name: "Lead");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Boleto");
        }
    }
}
