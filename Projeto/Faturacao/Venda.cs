using Projeto.Lib.Entidades;
using Projeto.Lib.Infraestrutura;
using System;
using System.Text;

namespace Projeto.Lib.Faturacao
{
    public class Venda : IImpressora
    {
        public Utilizador Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public PontoDeVenda PontoDeVenda { get; set; }
        public DateTime DataHoraVenda { get; set; }
        public int NumeroSerie { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public decimal ValorPagamento { get; set; }
        public DetalheDeVenda DetalheDeVenda { get; set; }


        public void GerarRecibo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Fatura Recibo FRD {DataHoraVenda.Year}/{NumeroSerie}");
            sb.AppendLine($"Loja: {PontoDeVenda.Loja.NIF} - Ponto de Venda: {PontoDeVenda.Identificador} ");
            sb.AppendLine($"Loja: {PontoDeVenda.Loja.MoradaPessoa}");
            sb.AppendLine($"Vendedor: {Vendedor.Nome} Identificador: {Vendedor.Identificador} ");
            sb.AppendLine($"Data da Fatura/Recibo: {DataHoraVenda} ");
            sb.AppendLine($"Tipo Pagamento: {TipoPagamento} "); //TODO: Trocar enumerador por string
            sb.AppendLine($"Valor Pagamento: {ValorPagamento} ");
            foreach (var item in DetalheDeVenda.Artigos)
            {
                sb.AppendLine($"{item.Nome} (NS: {item.NumeroSerie})   {item.PrecoUnitario} €/un ");
            }

            //Poderíamos escrever usando a notação LINQ
            //DetalheVenda.Produtos.Select(x => sb.AppendLine($"Nome: {x.Nome}  - Valor Unitario: {x.PrecoUnitario} - Número de Série: {x.NumeroSerie}"))
        }
    }
}