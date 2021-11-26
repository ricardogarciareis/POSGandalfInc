using System.Collections.Generic;
using System.Linq;
using System;
using Projeto.Lib.Repositorios;
using Projeto.DAL.Entidades;

namespace Projeto.DAL.Repositorios
{
    //06/11/2021 24:00 f2
    public class RepositorioEntidade : IRepositorio<Entidade>
    {
        private readonly List<Entidade> ListaEntidades;

        //Construtor
        public RepositorioEntidade()
        {
            ListaEntidades = new List<Entidade>();
        }

        #region Create
        public void Criar(Entidade t)
        {
            ListaEntidades.Add(t);
        }
        #endregion

        #region Read
        public Entidade ObterPorIdentificador(Guid guid)
        {
            return ListaEntidades.FirstOrDefault(x => x.Id == guid);
        }

        public Entidade ObterPorNome(string nome)
        {
            return ListaEntidades.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Entidade> ObterTodos()
        {
            return ListaEntidades;
        }
        #endregion

        #region Update
        public void Atualizar(Entidade t, Entidade novosDados)
        {
            var temp = t.Id;
            t = novosDados;
            t.Id = temp;
        }
        #endregion

        #region Delete
        public void Apagar(Entidade t)
        {
            ListaEntidades.Remove(t);
        }
        #endregion

 

        
    }
}
