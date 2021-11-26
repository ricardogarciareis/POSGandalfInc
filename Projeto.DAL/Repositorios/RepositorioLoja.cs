using Projeto.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.DAL.Repositorios
{
    public class RepositorioLoja
    {
        private List<Loja> ListaLojas;
        public RepositorioLoja()
        {
            ListaLojas = new List<Loja>();
            var loja0 = new Loja
            {
                Nome = "Nome do Loja 0",
                NIF = "500456780",
                Local = "Local 0"
            };
            ListaLojas.Add(loja0);

            var loja1 = new Loja
            {
                Nome = "Nome do Loja 1",
                NIF = "500456781",
                Local = "Local 1"
            };
            ListaLojas.Add(loja1);

            var loja2 = new Loja
            {
                Nome = "Nome do Loja 2",
                NIF = "500456782",
                Local = "Local 2"
            };
            ListaLojas.Add(loja2);
        }

        /*
        public void Apagar(Loja obj)
        {
            ListaLojas.Remove(obj);
        }

        public Loja Atualizar(string nomeAntigo, string nomeNovo)
        {
            var temp = ObterPorNome(nomeAntigo);
            temp.Nome = nomeNovo;
            return temp;
        }

        public Loja Atualizar(Loja t, Loja novosDados)
        {
            throw new NotImplementedException();
        }

        public void Criar(Loja obj)
        {
            ListaLojas.Add(obj);
        }
        */
        #region Read
        public Loja ObterPorIdentificador(Guid guid)
        {
            return ListaLojas.FirstOrDefault(x => x.Id == guid);
        }

        public Loja ObterPorNome(string nome)
        {
            return ListaLojas.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Loja> ObterTodos()
        {
            return ListaLojas;
        }
        #endregion
    }
}
