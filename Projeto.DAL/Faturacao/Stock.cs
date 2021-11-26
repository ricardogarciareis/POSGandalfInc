using Projeto.DAL.Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DAL.Faturacao
{
    public class Stock
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public List<Artigo> ListaArtigosParaVenda { get; set; }


        

        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    foreach (var item in ListaArtigosParaVenda)
        //    {
        //        sb.AppendLine("|       Referência: " + item.ReferenciaEAN);
        //        sb.AppendLine("|             Nome: " + item.Nome);
        //        sb.AppendLine("|   Preço Unitário: " + item.PrecoUnitario);
        //        sb.AppendLine("|  Número de Série: " + item.NumeroSerie);
        //        sb.AppendLine("|        Categoria: " + item.CategoriaArtigo.Nome);
        //    }
        //    sb.Append("+-----------------------------------------------------------------+");
        //    return sb.ToString();
        //}
    }
}
