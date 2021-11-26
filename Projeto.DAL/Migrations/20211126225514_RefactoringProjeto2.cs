using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.DAL.Migrations
{
    public partial class RefactoringProjeto2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Moradas_MoradaPessoaId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_Moradas_MoradaPessoaId",
                table: "Fornecedores");

            migrationBuilder.DropForeignKey(
                name: "FK_Lojas_Moradas_MoradaPessoaId",
                table: "Lojas");

            migrationBuilder.DropColumn(
                name: "Local",
                table: "Lojas");

            migrationBuilder.RenameColumn(
                name: "MoradaPessoaId",
                table: "Lojas",
                newName: "MoradaId");

            migrationBuilder.RenameIndex(
                name: "IX_Lojas_MoradaPessoaId",
                table: "Lojas",
                newName: "IX_Lojas_MoradaId");

            migrationBuilder.RenameColumn(
                name: "MoradaPessoaId",
                table: "Fornecedores",
                newName: "MoradaId");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedores_MoradaPessoaId",
                table: "Fornecedores",
                newName: "IX_Fornecedores_MoradaId");

            migrationBuilder.RenameColumn(
                name: "MoradaPessoaId",
                table: "Clientes",
                newName: "MoradaId");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_MoradaPessoaId",
                table: "Clientes",
                newName: "IX_Clientes_MoradaId");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Moradas",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Distrito",
                table: "Moradas",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "NomeDoGerente",
                table: "Lojas",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CategoriasArtigos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasArtigos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalhesDeVenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalhesDeVenda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PontosDeVendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LojaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontosDeVendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PontosDeVendas_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fechada = table.Column<bool>(type: "bit", nullable: false),
                    VendedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PontoDeVendaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataHoraVenda = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    NumeroSerie = table.Column<int>(type: "int", nullable: true),
                    TipoPagamento = table.Column<int>(type: "int", nullable: false),
                    ValorPagamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetalheVendaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendas_DetalhesDeVenda_DetalheVendaId",
                        column: x => x.DetalheVendaId,
                        principalTable: "DetalhesDeVenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendas_PontosDeVendas_PontoDeVendaId",
                        column: x => x.PontoDeVendaId,
                        principalTable: "PontosDeVendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendas_Utilizadores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Utilizadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Artigos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriaArtigoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReferenciaEAN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FornecedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PrecoUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetalheDeVendaId = table.Column<int>(type: "int", nullable: true),
                    StockId = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artigos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artigos_CategoriasArtigos_CategoriaArtigoId",
                        column: x => x.CategoriaArtigoId,
                        principalTable: "CategoriasArtigos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artigos_DetalhesDeVenda_DetalheDeVendaId",
                        column: x => x.DetalheDeVendaId,
                        principalTable: "DetalhesDeVenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artigos_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artigos_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_CategoriaArtigoId",
                table: "Artigos",
                column: "CategoriaArtigoId");

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_DetalheDeVendaId",
                table: "Artigos",
                column: "DetalheDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_FornecedorId",
                table: "Artigos",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_StockId",
                table: "Artigos",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_PontosDeVendas_LojaId",
                table: "PontosDeVendas",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClienteId",
                table: "Vendas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_DetalheVendaId",
                table: "Vendas",
                column: "DetalheVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_PontoDeVendaId",
                table: "Vendas",
                column: "PontoDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_VendedorId",
                table: "Vendas",
                column: "VendedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Moradas_MoradaId",
                table: "Clientes",
                column: "MoradaId",
                principalTable: "Moradas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_Moradas_MoradaId",
                table: "Fornecedores",
                column: "MoradaId",
                principalTable: "Moradas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lojas_Moradas_MoradaId",
                table: "Lojas",
                column: "MoradaId",
                principalTable: "Moradas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Moradas_MoradaId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_Moradas_MoradaId",
                table: "Fornecedores");

            migrationBuilder.DropForeignKey(
                name: "FK_Lojas_Moradas_MoradaId",
                table: "Lojas");

            migrationBuilder.DropTable(
                name: "Artigos");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "CategoriasArtigos");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "DetalhesDeVenda");

            migrationBuilder.DropTable(
                name: "PontosDeVendas");

            migrationBuilder.DropColumn(
                name: "NomeDoGerente",
                table: "Lojas");

            migrationBuilder.RenameColumn(
                name: "MoradaId",
                table: "Lojas",
                newName: "MoradaPessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Lojas_MoradaId",
                table: "Lojas",
                newName: "IX_Lojas_MoradaPessoaId");

            migrationBuilder.RenameColumn(
                name: "MoradaId",
                table: "Fornecedores",
                newName: "MoradaPessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedores_MoradaId",
                table: "Fornecedores",
                newName: "IX_Fornecedores_MoradaPessoaId");

            migrationBuilder.RenameColumn(
                name: "MoradaId",
                table: "Clientes",
                newName: "MoradaPessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_MoradaId",
                table: "Clientes",
                newName: "IX_Clientes_MoradaPessoaId");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Moradas",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Distrito",
                table: "Moradas",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Local",
                table: "Lojas",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Moradas_MoradaPessoaId",
                table: "Clientes",
                column: "MoradaPessoaId",
                principalTable: "Moradas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_Moradas_MoradaPessoaId",
                table: "Fornecedores",
                column: "MoradaPessoaId",
                principalTable: "Moradas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lojas_Moradas_MoradaPessoaId",
                table: "Lojas",
                column: "MoradaPessoaId",
                principalTable: "Moradas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
