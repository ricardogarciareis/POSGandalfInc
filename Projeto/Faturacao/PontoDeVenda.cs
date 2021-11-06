using Projeto.Lib.Entidades;
using System;
using System.Text;

namespace Projeto.Lib.Faturacao
{
    public class PontoDeVenda : Entidade
    {
        public Loja Loja { get; set; }


        public PontoDeVenda()
        {
            //Ativo = true;
            //DataCriacao = DateTime.Now;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|               ID: " + Identificador);
            sb.AppendLine("|            Ativo: " + Ativo);
            //sb.AppendLine("|       Designação: " + Loja.Nome);
            //sb.AppendLine("|            Local: " + Loja.Local);
            sb.AppendLine("|          Criação: " + DataCriacao);
            sb.AppendLine("| Última Alteração: " + DataAlteracao);

            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }
    }
}
