using Projeto.DAL.Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DAL.Faturacao
{
    public class DetalheDeVenda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<Artigo> ListaDeArtigos { get; set; }



        //O que fazer?

        //public DetalheDeVenda()
        //{
        //    ListaDeArtigos = new List<Artigo>();
        //}

        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    foreach(var item in ListaDeArtigos)
        //    {
        //        sb.AppendLine("|       Referência: " + item.ReferenciaEAN);
        //        sb.AppendLine("|             Nome: " + item.Nome);
        //        sb.AppendLine("|   Preço Unitário: " + item.PrecoUnitario);
        //        sb.AppendLine("|  Número de Série: " + item.NumeroSerie);
        //    }
        //    sb.Append("+-----------------------------------------------------------------+");
        //    return sb.ToString();
        //}
    }
}
