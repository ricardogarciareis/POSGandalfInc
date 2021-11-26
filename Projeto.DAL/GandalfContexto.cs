using Microsoft.EntityFrameworkCore;
using Projeto.DAL.Entidades;
using Projeto.DAL.Faturacao;

namespace Projeto.DAL
{
    public class GandalfContexto : DbContext
    {
        //Entidades
        public DbSet<Artigo> Artigos { get; set; }
        public DbSet<CategoriaArtigo> CategoriasArtigos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Morada> Moradas { get; set; }
        public DbSet<Utilizador> Utilizadores { get; set; }

        //Faturacao
        public DbSet<DetalheDeVenda> DetalhesDeVenda { get; set; }
        public DbSet<PontoDeVenda> PontosDeVendas { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        
        //TipoPagamento é um Enumerable (não é tabela)

        //Configuração do Provider
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = @"Server=(LocalDB)\MSSQLLocalDB;Database=GandalfIncDB;Trusted_Connection=True;";
            options.UseSqlServer(connectionString);
        }

    }
}
