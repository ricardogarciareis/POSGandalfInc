using Projeto.Lib.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Projeto.Lib.Repositorios
{
    public class RepositorioArtigo : IRepositorio<Artigo>
    {
        private List<Artigo> ListaArtigos;
        public RepositorioArtigo()
        {
            ListaArtigos = new List<Artigo>();
            var artigo0 = new Artigo
            {
                Nome = "Nome do Artigo 0",
                ReferenciaEAN = "ean00000000",
                Fabricante = "Fabricante 0",
                NumeroSerie = "ns000000/0",
                PrecoUnitario = 100.00M
            };
            ListaArtigos.Add(artigo0);

            var artigo1 = new Artigo
            {
                Nome = "Nome do Artigo 1",
                ReferenciaEAN = "ean00000001",
                Fabricante = "Fabricante 1",
                NumeroSerie = "ns000000/1",
                PrecoUnitario = 101.01M
            };
            ListaArtigos.Add(artigo1);

            var artigo2 = new Artigo
            {
                Nome = "Nome do Artigo 2",
                ReferenciaEAN = "ean00000002",
                Fabricante = "Fabricante 2",
                NumeroSerie = "ns000000/2",
                PrecoUnitario = 102.02M
            };
            ListaArtigos.Add(artigo2);
        }


        public void Apagar(Artigo obj)
        {
            ListaArtigos.Remove(obj);
        }

        public Artigo Atualizar(string nomeAntigo, string nomeNovo)
        {
            var temp = ObterPorNome(nomeAntigo);
            temp.Nome = nomeNovo;
            return temp;
        }

        public void Criar(Artigo obj)
        {
            ListaArtigos.Add(obj);
        }

        public Artigo ObterPorNome(string Nome)
        {
            var dadosArtigo = ListaArtigos
                                .Where(x => x.Nome == Nome)
                                .OrderByDescending(x => x.Nome)
                                .FirstOrDefault();
            return dadosArtigo;
        }

        public List<Artigo> ObterTodos()
        {
            return ListaArtigos;
        }
    }
}