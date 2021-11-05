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

        private DateTime dataAlteracao;
        public DateTime DataAlteracao
        {
            get { return dataAlteracao; }
            set { 
                if(dataAlteracao == new DateTime())
                {
                    dataAlteracao = DateTime.Now;
                }
                dataAlteracao = value;
            }
        }

        public Entidade()
        {
            Identificador = Guid.NewGuid();
        }

        public Entidade(string nome)
        {
            Nome = nome;
            Identificador = Guid.NewGuid();
        }

    }
}
