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

        public Entidade()
        {
            Identificador = Guid.NewGuid();
        }

        public Entidade(string nome)
        {
            Nome = nome;
            Identificador = Guid.NewGuid();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|   ID: " + Identificador);
            sb.AppendLine("| Nome: " + Nome);
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }
    }
}
