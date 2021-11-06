using Projeto.Lib.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Projeto.Lib.Repositorios
{
    public class RepositorioCliente
    {
        private List<Cliente> ListaClientes;
        public RepositorioCliente()
        {
            ListaClientes = new List<Cliente>();
            var cliente0 = new Cliente
            {
                Nome = "Nome do Cliente 0",
                NIF = "123456780",
                DataNascimento = DateTime.Parse("10/10/2000"),
                MoradaPessoa = new Morada()
                {
                    Endereco = "Rua 0, N.º 0",
                    CodigoPostal = "1234-560",
                    Localidade = "Localidade0",
                    Observacoes = "Olá Mundo0!"
                }
        };
            ListaClientes.Add(cliente0);

            var cliente1 = new Cliente
            {
                Nome = "Nome do Cliente 1",
                NIF = "123456781",
                DataNascimento = DateTime.Parse("11/11/2001"),
                MoradaPessoa = new Morada()
                {
                    Endereco = "Rua 1, N.º 1",
                    CodigoPostal = "1234-561",
                    Localidade = "Localidade1",
                    Observacoes = "Olá Mundo1!"
                }
            };
            ListaClientes.Add(cliente1);

            var cliente2 = new Cliente
            {
                Nome = "Nome do Cliente 2",
                NIF = "123456782",
                DataNascimento = DateTime.Parse("12/12/2002"),
                MoradaPessoa = new Morada()
                {
                    Endereco = "Rua 2, N.º 2",
                    CodigoPostal = "1234-562",
                    Localidade = "Localidade2",
                    Observacoes = "Olá Mundo2!"
                }
            };
            ListaClientes.Add(cliente2);
        }

        /*
        public void Apagar(Cliente obj)
        {
            ListaClientes.Remove(obj);
        }

        public Cliente Atualizar(string nomeAntigo, string nomeNovo)
        {
            var temp = ObterPorNome(nomeAntigo);
            temp.Nome = nomeNovo;
            return temp;
        }

        public Cliente Atualizar(Cliente t, Cliente novosDados)
        {
            throw new NotImplementedException();
        }

        public void Criar(Cliente obj)
        {
            ListaClientes.Add(obj);
        }
        */
        #region Read
        public Cliente ObterPorIdentificador(Guid guid)
        {
            return ListaClientes.FirstOrDefault(x => x.Identificador == guid);
        }

        public Cliente ObterPorNome(string nome)
        {
            return ListaClientes.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Cliente> ObterTodos()
        {
            return ListaClientes;
        }
        #endregion
    }
}
