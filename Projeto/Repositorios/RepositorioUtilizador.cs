using Projeto.Lib.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Lib.Repositorios
{
    public class RepositorioUtilizador : IRepositorio<Utilizador>
    {
        private List<Utilizador> ListaUtilizadores;
        public RepositorioUtilizador()
        {
            ListaUtilizadores = new List<Utilizador>();
            var utilizador0 = new Utilizador
            {
                Nome = "Nome do Utilizador 0",
                NIF = "223456780",
                UserName = "User0",
                Password = "passuser0"
            };
            ListaUtilizadores.Add(utilizador0);

            var utilizador1 = new Utilizador
            {
                Nome = "Nome do Utilizador 1",
                NIF = "223456781",
                UserName = "User1",
                Password = "passuser1"
            };
            ListaUtilizadores.Add(utilizador1);

            var utilizador2 = new Utilizador
            {
                Nome = "Nome do Utilizador 2",
                NIF = "223456782",
                UserName = "User2",
                Password = "passuser2"
            };
            ListaUtilizadores.Add(utilizador2);
        }

        
        public void Apagar(Utilizador obj)
        {
            ListaUtilizadores.Remove(obj);
        }

        public Utilizador Atualizar(string nomeAntigo, string nomeNovo)
        {
            var temp = ObterPorNome(nomeAntigo);
            temp.Nome = nomeNovo;
            return temp;
        }

        public void Criar(Utilizador obj)
        {
            ListaUtilizadores.Add(obj);
        }

        public Utilizador ObterPorNome(string Nome)
        {
            var dadosUtilizador = ListaUtilizadores
                                .Where(x => x.Nome == Nome)
                                .OrderByDescending(x => x.NIF)
                                .FirstOrDefault();
            return dadosUtilizador;
        }

        public List<Utilizador> ObterTodos()
        {
            return ListaUtilizadores;
        }
    }
}
