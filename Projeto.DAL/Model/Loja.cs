using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.DAL.Model
{
    public class Loja : Pessoa
    {
        [MaxLength(255)]
        public string Local { get; set; }

        //O que fazer?

        //public Loja()
        //{

        //}

        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.AppendLine("|               ID: " + Id);
        //    sb.AppendLine("|            Ativo: " + Ativo);
        //    sb.AppendLine("|       Designação: " + Nome);
        //    sb.AppendLine("|              NIF: " + NIF);
        //    sb.AppendLine("|      Localização: " + Local);
        //    //sb.AppendLine("|         Endereço: " + Morada.Endereco);
        //    //sb.AppendLine("|    Código Postal: " + Morada.CodigoPostal);
        //    //sb.AppendLine("|       Localidade: " + Morada.Localidade);
        //    //sb.AppendLine("|      Observações: " + Morada.Observacoes);
        //    sb.AppendLine("|          Criação: " + DataCriacao);
        //    sb.AppendLine("| Última Alteração: " + DataAlteracao);
        //    sb.Append("+-----------------------------------------------------------------+");
        //    return sb.ToString();
        //}


    }
}
