﻿using Projeto.Lib.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Lib.Repositorios
{
    public class RepositorioCliente : IRepositorio<Cliente>
    {
        private List<Cliente> ListaClientes;
        public RepositorioCliente()
        {
            ListaClientes = new List<Cliente>();
            var cliente0 = new Cliente
            {
                Nome = "Nome do Cliente 0",
                NIF = "123456780"
            };
            ListaClientes.Add(cliente0);

            var cliente1 = new Cliente
            {
                Nome = "Nome do Cliente 1",
                NIF = "123456781"
            };
            ListaClientes.Add(cliente1);

            var cliente2 = new Cliente
            {
                Nome = "Nome do Cliente 2",
                NIF = "123456782"
            };
            ListaClientes.Add(cliente2);
        }

        
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

        public void Criar(Cliente obj)
        {
            ListaClientes.Add(obj);
        }

        public Cliente ObterPorNome(string Nome)
        {
            var dadosCliente = ListaClientes
                                .Where(x => x.Nome == Nome)
                                .OrderByDescending(x => x.NIF)
                                .FirstOrDefault();
            return dadosCliente;
        }

        public List<Cliente> ObterTodos()
        {
            return ListaClientes;
        }
    }
}