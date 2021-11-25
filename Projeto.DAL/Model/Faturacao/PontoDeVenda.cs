using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Projeto.DAL.Model
{
    public class PontoDeVenda : Entidade
    {
        public Loja Loja { get; set; }


        //public PontoDeVenda()
        //{
        //    //Ativo = true;
        //    //DataCriacao = DateTime.Now;
        //}

        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.AppendLine("|               ID: " + Id);
        //    sb.AppendLine("|            Ativo: " + Ativo);
        //    //sb.AppendLine("|       Designação: " + Loja.Nome);
        //    //sb.AppendLine("|            Local: " + Loja.Local);
        //    sb.AppendLine("|          Criação: " + DataCriacao);
        //    sb.AppendLine("| Última Alteração: " + DataAlteracao);

        //    sb.Append("+-----------------------------------------------------------------+");
        //    return sb.ToString();
        //}
    }
}
