using Microsoft.EntityFrameworkCore;

namespace Projeto.DAL.Model
{
    public class GandalfContexto : DbContext
    {
        public DbSet<Morada> Moradas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        //public DbSet<CategoriaArtigo> CategoriasArtigos { get; set; }
        //public DbSet<Artigo> Artigos { get; set; }

        //Configuração do Provider
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = @"Server=(LocalDB)\MSSQLLocalDB;Database=GandalfIncDB;Trusted_Connection=True;";
            options.UseSqlServer(connectionString);
        }

    }
}
