using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Lib.Repositorios
{
    public interface IRepositorio<T>
    {
        //CRUD 06/11/2021 16:50 f2
        void Criar(T t);
        T ObterPorIdentificador(Guid guid);
        T ObterPorNome(string Nome);
        List<T> ObterTodos();
        void Atualizar(T t, T novosDados);
        void Apagar(T t);

    }
}
