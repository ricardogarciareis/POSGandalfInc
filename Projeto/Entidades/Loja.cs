using System.Text;

namespace Projeto.Lib.Entidades
{
    public class Loja : Pessoa
    {
        public string Local { get; set; }

        public Loja()
        {
            
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
            sb.AppendLine("|          Criação: " + DataCriacao);
            sb.AppendLine("| Última Alteração: " + DataAlteracao);
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }


    }
}
