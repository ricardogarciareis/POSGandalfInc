using Projeto.Lib.Entidades;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Lib.Faturacao
{
    public class DetalheDeVenda
    {
        public List<Artigo> ListaDeArtigos { get; set; }

        public DetalheDeVenda()
        {
            ListaDeArtigos = new List<Artigo>();
        }

        


        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(var item in ListaDeArtigos)
            {
                sb.AppendLine("|       Referência: " + item.ReferenciaEAN);
                sb.AppendLine("|             Nome: " + item.Nome);
                sb.AppendLine("|   Preço Unitário: " + item.PrecoUnitario);
                sb.AppendLine("|  Número de Série: " + item.NumeroSerie);
            }
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }
    }
}
