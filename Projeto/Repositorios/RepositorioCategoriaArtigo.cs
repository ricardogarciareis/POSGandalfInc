using Projeto.Lib.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Projeto.Lib.Repositorios
{
    public class RepositorioCategoriaArtigo : IRepositorio<CategoriaArtigo>
    {
        private List<CategoriaArtigo> ListaCategoriasArtigos;
        public RepositorioCategoriaArtigo()
        {
            ListaCategoriasArtigos = new List<CategoriaArtigo>();
            var categoriaArtigo0 = new CategoriaArtigo
            {
                Nome = "Nome da Categoria de Artigo 0"
            };
            ListaCategoriasArtigos.Add(categoriaArtigo0);

            var categoriaArtigo1 = new CategoriaArtigo
            {
                Nome = "Nome da Categoria de Artigo 1"
            };
            ListaCategoriasArtigos.Add(categoriaArtigo1);

            var categoriaArtigo2 = new CategoriaArtigo
            {
                Nome = "Nome da Categoria de Artigo 2"
            };
            ListaCategoriasArtigos.Add(categoriaArtigo2);
        }


        public void Apagar(CategoriaArtigo obj)
        {
            ListaCategoriasArtigos.Remove(obj);
        }

        public CategoriaArtigo Atualizar(string nomeAntigo, string nomeNovo)
        {
            var temp = ObterPorNome(nomeAntigo);
            temp.Nome = nomeNovo;
            return temp;
        }

        public void Criar(CategoriaArtigo obj)
        {
            ListaCategoriasArtigos.Add(obj);
        }

        public CategoriaArtigo ObterPorNome(string Nome)
        {
            var dadosCategoriasArtigo = ListaCategoriasArtigos
                                .Where(x => x.Nome == Nome)
                                .OrderByDescending(x => x.Nome)
                                .FirstOrDefault();
            return dadosCategoriasArtigo;
        }

        public List<CategoriaArtigo> ObterTodos()
        {
            return ListaCategoriasArtigos;
        }
    }
}