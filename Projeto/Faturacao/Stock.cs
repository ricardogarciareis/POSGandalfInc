using Projeto.DAL.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Lib.Faturacao
{
    public class Stock
    {
        public List<Artigo> ListaArtigosParaVenda { get; set; }


        public bool ValidarDisponibilidade(List<Artigo> listaArtigosDaVenda)
        {
            var listaVendaAgrupada = listaArtigosDaVenda
                                    .GroupBy(x => x.Nome)
                                    .Select(x => new { Nome = x.Key, Quantidade = x.Count()}).ToList();

            //Impedir devolução de produto
            var existemValoresInvalidos = listaVendaAgrupada.Any(x => x.Quantidade <= 0);
            if(existemValoresInvalidos || listaArtigosDaVenda.Count <= 0)
            {
                return false;
            }
            
            foreach(var itemAgrupado in listaVendaAgrupada)
            {
                //Usar Nome apenas como simplifcação
                var qtdStock = ListaArtigosParaVenda.Where(x => x.Nome == itemAgrupado.Nome).Count();
                var qtdVenda = itemAgrupado.Quantidade;
                if (qtdVenda > qtdStock)
                {
                    return false;
                }
            }  
            return true;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in ListaArtigosParaVenda)
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
