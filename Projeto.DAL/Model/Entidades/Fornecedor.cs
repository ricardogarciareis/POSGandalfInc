using System.ComponentModel.DataAnnotations;

namespace Projeto.DAL.Model
{
    public class Fornecedor : Pessoa
    {
        [Range(0,5)]
        public int Pontuacao { get; set; }  //Classificação do Fornecedor

        //O que fazer?

        //public Fornecedor()
        //{

        //}

        //public static bool NIFValido()
        //{
        //    return false;
        //}

        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.AppendLine("|               ID: " + Id);
        //    sb.AppendLine("|            Ativo: " + Ativo);
        //    sb.AppendLine("|       Designação: " + Nome);
        //    sb.AppendLine("|              NIF: " + NIF);
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
