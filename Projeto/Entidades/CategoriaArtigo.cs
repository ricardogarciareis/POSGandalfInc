using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Lib.Entidades
{
    public class CategoriaArtigo : Entidade
    {


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|               ID: " + Identificador);
            sb.AppendLine("|            Ativo: " + Ativo);
            sb.AppendLine("|             Nome: " + Nome);
            sb.AppendLine("| Última Alteração: " + DataAlteracao);
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }
    }
}
