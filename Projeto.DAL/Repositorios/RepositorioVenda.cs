using System.Collections.Generic;
using System.Linq;
using System;
using Projeto.DAL.Faturacao;
using Projeto.DAL.Entidades;

namespace Projeto.DAL.Repositorios
{
    public class RepositorioVenda
    {
        public Guid id { get; set; }

        private List<Venda> ListaVendas;
        public RepositorioVenda()
        {
            ListaVendas = new List<Venda>();
            var venda0 = new Venda
            {
                DetalheVenda = new DetalheDeVenda()
                {
                    ListaDeArtigos = new List<Artigo>()
                    {
                        new Artigo { Nome = "Artigo 0", NumeroSerie = "1000000.00", PrecoUnitario = 10.90M },
                        new Artigo { Nome = "Artigo 0", NumeroSerie = "1000000.01", PrecoUnitario = 10.90M },
                        new Artigo { Nome = "Artigo 1", NumeroSerie = "1000001.00", PrecoUnitario = 20.90M }
                    }
                }
            };
            ListaVendas.Add(venda0);
            id = venda0.Id;

            var venda1 = new Venda
            {
                DetalheVenda = new DetalheDeVenda()
                {
                    ListaDeArtigos = new List<Artigo>()
                    {
                        new Artigo { Nome = "Artigo 0", NumeroSerie = "1000000.00", PrecoUnitario = 10.00M },
                        new Artigo { Nome = "Artigo 0", NumeroSerie = "1000000.01", PrecoUnitario = 10.00M },
                        new Artigo { Nome = "Artigo 1", NumeroSerie = "1000001.00", PrecoUnitario = 20.00M }
                    }
                }
            };
            ListaVendas.Add(venda1);
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
        */

        public void Criar(Venda obj)
        {
            ListaVendas.Add(obj);
        }

        #region Read
        public Venda ObterPorIdentificador(Guid guid)
        {
            return ListaVendas.FirstOrDefault(x => x.Id == guid);
        }

        //public Venda ObterPorNome(string nome)
        //{
        //    return ListaVendas.FirstOrDefault(x => x.Nome == nome);
        //}

        public List<Venda> ObterTodos()
        {
            return ListaVendas;
        }
        #endregion

        public decimal CalcularTotalPorIdentificador(Guid id)
        {
            decimal soma = 0;
            var venda = ListaVendas.Where(x => x.Id == id).FirstOrDefault();
            var lista = venda.DetalheVenda.ListaDeArtigos.ToList();
            foreach (var item in lista)
            {
                soma += item.PrecoUnitario;
            }
            return soma;
        }

        public decimal CalcularTotalPorIdentificador()
        {
            decimal soma = 0;
            var venda = ListaVendas.Where(x => x.Id == id).FirstOrDefault();
            var lista = venda.DetalheVenda.ListaDeArtigos.ToList();
            foreach (var item in lista)
            {
                soma += item.PrecoUnitario;
            }
            return soma;
        }

        public decimal CalcularTotalDeVendas()
        {
            decimal soma = 0;
            foreach (var i in ListaVendas)
            {
                foreach (var j in i.DetalheVenda.ListaDeArtigos)
                {
                    soma += j.PrecoUnitario;
                }
            }
            return soma;
        }

    }
}
