using System;
using System.Text;

namespace Projeto.Lib.Entidades
{
    public class Cliente : Pessoa
    {
        public DateTime DataNascimento { get; set; }


        public Cliente()
        {
            Ativo = true;
            DataAlteracao = DateTime.Now;
        }

        public static bool NIFValido()
        {
            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|               ID: " + Identificador);
            sb.AppendLine("|            Ativo: " + Ativo);
            sb.AppendLine("|       Designação: " + Nome);
            sb.AppendLine("|              NIF: " + NIF);
            sb.AppendLine("|  Data Nascimento: " + DataNascimento.ToString("dd/MM/yyyy"));
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
