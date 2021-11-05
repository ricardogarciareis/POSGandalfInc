using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Lib.Entidades
{
    public class Loja : Pessoa
    {
        public string Local { get; set; }

        public Loja()
        {
            Ativo = true;
            DataAlteracao = DateTime.Now;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|               ID: " + Identificador);
            sb.AppendLine("|            Ativo: " + Ativo);
            sb.AppendLine("|       Designação: " + Nome);
            sb.AppendLine("|              NIF: " + NIF);
            sb.AppendLine("|      Localização: " + Local);
            //sb.AppendLine("|         Endereço: " + Morada.Endereco);
            //sb.AppendLine("|    Código Postal: " + Morada.CodigoPostal);
            //sb.AppendLine("|       Localidade: " + Morada.Localidade);
            //sb.AppendLine("|      Observações: " + Morada.Observacoes);
            sb.AppendLine("| Última Alteração: " + DataAlteracao);
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }


    }
}
