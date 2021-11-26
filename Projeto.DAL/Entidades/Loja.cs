using System.ComponentModel.DataAnnotations;

namespace Projeto.DAL.Entidades
{
    public class Loja : Pessoa
    {
        [Required]
        [MaxLength(255)]
        public string NomeDoGerente { get; set; }

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
