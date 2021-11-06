using Projeto.Lib.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Projeto.Lib.Repositorios
{
    public class RepositorioArtigo
    {
        public List<Artigo> ListaArtigos;
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

        /*
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

        public Artigo Atualizar(Artigo t, Artigo novosDados)
        {
            throw new NotImplementedException();
        }

        public void Criar(Artigo obj)
        {
            ListaArtigos.Add(obj);
        }
        */
        #region Read
        public Artigo ObterPorIdentificador(Guid guid)
        {
            return ListaArtigos.FirstOrDefault(x => x.Identificador == guid);
        }

        public Artigo ObterPorNome(string nome)
        {
            return ListaArtigos.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Artigo> ObterTodos()
        {
            return ListaArtigos;
        }
        #endregion
    }
}