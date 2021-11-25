using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.DAL.Model
{
    public class RepositorioUtilizador
    {
        private List<Utilizador> ListaUtilizadores;
        public RepositorioUtilizador()
        {
            ListaUtilizadores = new List<Utilizador>();
            var utilizador0 = new Utilizador
            {
                Nome = "Nome do Utilizador 0",
                Email = "User0",
                Password = "passuser0"
            };
            ListaUtilizadores.Add(utilizador0);

            var utilizador1 = new Utilizador
            {
                Nome = "Nome do Utilizador 1",
                Email = "User1",
                Password = "passuser1"
            };
            ListaUtilizadores.Add(utilizador1);

            var utilizador2 = new Utilizador
            {
                Nome = "Nome do Utilizador 2",
                Email = "User2",
                Password = "passuser2"
            };
            ListaUtilizadores.Add(utilizador2);
        }

        /*
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

        public Utilizador Atualizar(Utilizador t, Utilizador novosDados)
        {
            throw new NotImplementedException();
        }

        public void Criar(Utilizador obj)
        {
            ListaUtilizadores.Add(obj);
        }
        */
        #region Read
        public Utilizador ObterPorIdentificador(Guid guid)
        {
            return ListaUtilizadores.FirstOrDefault(x => x.Id == guid);
        }

        public Utilizador ObterPorNome(string nome)
        {
            return ListaUtilizadores.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Utilizador> ObterTodos()
        {
            return ListaUtilizadores;
        }
        #endregion
    }
}
