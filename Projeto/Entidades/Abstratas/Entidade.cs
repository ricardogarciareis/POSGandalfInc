using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Lib.Entidades
{
    public abstract class Entidade
    {
        public Guid Identificador { get; set; }
        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }


        public Entidade()
        {
            Identificador = Guid.NewGuid();
            Ativo = true;
            DataCriacao = DateTime.Now;
        }

        public Entidade(string nome)
        {
            Nome = nome;
            Identificador = Guid.NewGuid();
            Ativo = true;
            DataCriacao = DateTime.Now;
        }

    }
}
