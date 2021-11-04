using Projeto.Lib.Entidades;
using System;
using System.Text;

namespace Projeto.Lib.Faturacao
{
    public class PontoDeVenda
    {
        public Guid Identificador { get; set; }
        public bool Ativo { get; set; }
        public Loja Loja { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|               ID: " + Identificador);
            sb.AppendLine("|            Ativo: " + Ativo);
            sb.AppendLine("|       Designação: " + Loja.Nome);
            sb.AppendLine("|            Local: " + Loja.Local);
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }
    }
}
