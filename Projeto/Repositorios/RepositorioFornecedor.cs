using Projeto.Lib.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Projeto.Lib.Repositorios
{
    public class RepositorioFornecedor : IRepositorio<Fornecedor>
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

        public void Criar(Fornecedor obj)
        {
            ListaFornecedores.Add(obj);
        }

        public Fornecedor ObterPorNome(string Nome)
        {
            var dadosFornecedor = ListaFornecedores
                                .Where(x => x.Nome == Nome)
                                .OrderByDescending(x => x.Nome)
                                .FirstOrDefault();
            return dadosFornecedor;
        }

        public List<Fornecedor> ObterTodos()
        {
            return ListaFornecedores;
        }
    }
}
