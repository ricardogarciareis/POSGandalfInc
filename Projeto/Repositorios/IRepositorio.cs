using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Lib.Repositorios
{
    public interface IRepositorio<T>
    {
        //CRUD
        void Criar(T obj);
        T ObterPorNome(string Nome);
        List<T> ObterTodos();
        T Atualizar(string nomeAntigo, string nomeNovo);
        void Apagar(T obj);

    }
}
