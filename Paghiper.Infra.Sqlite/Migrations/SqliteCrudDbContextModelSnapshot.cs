﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Paghiper.Infra.Sqlite.Context;

namespace Paghiper.Infra.Sqlite.Migrations
{
    [DbContext(typeof(SqliteCrudDbContext))]
    partial class SqliteCrudDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17");

            modelBuilder.Entity("PagHiper.Domain.Entities.Aluno.Aluno", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DataAtualizacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResponsavelCpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResponsavelNome")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResponsavelParentesco")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResponsavelTelefone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rg")
                        .HasColumnType("TEXT");

                    b.Property<char>("StatusCadastro")
                        .HasColumnType("TEXT");

                    b.Property<char>("StatusFinanceiro")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Aluno.AlunoContato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Contato")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tipo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.ToTable("AlunoContato");
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Aluno.AlunoMatricula", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CampanhaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CursoId")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DataMatricula")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroRegistro")
                        .HasColumnType("TEXT");

                    b.Property<string>("PagamentoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PagamentoTipoId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId")
                        .IsUnique();

                    b.ToTable("AlunoMatricula");
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Aluno.AlunoParcelas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataPagamentoEfetuado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroParcelas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumeroTotalParcelas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PagamentoEfetuado")
                        .HasColumnType("TEXT");

                    b.Property<string>("PagamentoEfetuadoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoPagamentoId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorEfetuado")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId")
                        .IsUnique();

                    b.ToTable("AlunoParcelas");
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Aluno.AlunoTurma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AlunoId")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("DataIngresso")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("TurmaId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("TurmaId");

                    b.ToTable("AlunoTurma");
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Boleto", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApiKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("DaysDueDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiscountCents")
                        .HasColumnType("TEXT");

                    b.Property<bool>("FixedDescription")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("NotificationUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayerCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayerComplement")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayerCpfCnpj")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayerDistrict")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayerEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayerNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayerPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayerState")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayerStreet")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayerZipCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShippingMethods")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShippingPriceCents")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeBankSlip")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderId");

                    b.ToTable("Boletos");
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Common.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Bairro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cep")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Complemento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rua")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uf")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("BoletoOrderId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("PriceCents")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BoletoOrderId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Turma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Aluno.AlunoContato", b =>
                {
                    b.HasOne("PagHiper.Domain.Entities.Aluno.Aluno", null)
                        .WithMany("Contatos")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Aluno.AlunoMatricula", b =>
                {
                    b.HasOne("PagHiper.Domain.Entities.Aluno.Aluno", null)
                        .WithOne("Matricula")
                        .HasForeignKey("PagHiper.Domain.Entities.Aluno.AlunoMatricula", "AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Aluno.AlunoParcelas", b =>
                {
                    b.HasOne("PagHiper.Domain.Entities.Aluno.Aluno", null)
                        .WithOne("Parcelas")
                        .HasForeignKey("PagHiper.Domain.Entities.Aluno.AlunoParcelas", "AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Aluno.AlunoTurma", b =>
                {
                    b.HasOne("PagHiper.Domain.Entities.Aluno.Aluno", null)
                        .WithMany("Turmas")
                        .HasForeignKey("AlunoId");

                    b.HasOne("PagHiper.Domain.Entities.Turma", "Turma")
                        .WithMany()
                        .HasForeignKey("TurmaId");
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Common.Endereco", b =>
                {
                    b.HasOne("PagHiper.Domain.Entities.Aluno.Aluno", null)
                        .WithOne("Endereco")
                        .HasForeignKey("PagHiper.Domain.Entities.Common.Endereco", "AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PagHiper.Domain.Entities.Item", b =>
                {
                    b.HasOne("PagHiper.Domain.Entities.Boleto", null)
                        .WithMany("Items")
                        .HasForeignKey("BoletoOrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
