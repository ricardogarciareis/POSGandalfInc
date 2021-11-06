using Projeto.Lib.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Projeto.Lib.Repositorios
{
    public class RepositorioFornecedor
    {
        private List<Fornecedor> ListaFornecedores;
        public RepositorioFornecedor()
        {
            ListaFornecedores = new List<Fornecedor>();
            var fornecedor0 = new Fornecedor
            {
                Nome = "Nome do Fornecedor 0",
                NIF = "123456780"
            };
            ListaFornecedores.Add(fornecedor0);

            var fornecedor1 = new Fornecedor
            {
                Nome = "Nome do Fornecedor 1",
                NIF = "123456781"
            };
            ListaFornecedores.Add(fornecedor1);

            var fornecedor2 = new Fornecedor
            {
                Nome = "Nome do Artigo 2",
                NIF = "123456782"
            };
            ListaFornecedores.Add(fornecedor2);
        }

        /*
        public void Apagar(Fornecedor obj)
        {
            ListaFornecedores.Remove(obj);
        }

        public Fornecedor Atualizar(string nomeAntigo, string nomeNovo)
        {
            var temp = ObterPorNome(nomeAntigo);
            temp.Nome = nomeNovo;
            return temp;
        }

        public Fornecedor Atualizar(Fornecedor t, Fornecedor novosDados)
        {
            throw new NotImplementedException();
        }

        public void Criar(Fornecedor obj)
        {
            ListaFornecedores.Add(obj);
        }
        */
        #region Read
        public Fornecedor ObterPorIdentificador(Guid guid)
        {
            return ListaFornecedores.FirstOrDefault(x => x.Identificador == guid);
        }

        public Fornecedor ObterPorNome(string nome)
        {
            return ListaFornecedores.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Fornecedor> ObterTodos()
        {
            return ListaFornecedores;
        }
        #endregion
    }
}
