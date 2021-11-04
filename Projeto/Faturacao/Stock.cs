using Projeto.Lib.Entidades;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Lib.Faturacao
{
    public class Stock
    {
        public List<Artigo> Artigos { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in Artigos)
            {
                sb.AppendLine("|       Referência: " + item.ReferenciaEAN);
                sb.AppendLine("|             Nome: " + item.Nome);
                sb.AppendLine("|   Preço Unitário: " + item.PrecoUnitario);
                sb.AppendLine("|  Número de Série: " + item.NumeroSerie);
                sb.AppendLine("|        Categoria: " + item.CategoriaArtigo.Nome);
            }
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }
    }
}
