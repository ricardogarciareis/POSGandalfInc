using Projeto.Lib.Entidades;
using Projeto.Lib.Infraestrutura;
using System;
using System.Text;

namespace Projeto.Lib.Faturacao
{
    public class Venda : IImpressora
    {
        public Guid Identificador { get; set; }
        public bool Fechada { get; set; }
        public Utilizador Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public PontoDeVenda PontoDeVenda { get; set; }
        public DateTime DataHoraVenda { get; set; }
        public int NumeroSerie { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public decimal ValorPagamento { get; set; }
        public DetalheDeVenda DetalheVenda { get; set; }

        public Venda()
        {
            Identificador = Guid.NewGuid();
            Fechada = false;
            DetalheVenda = new DetalheDeVenda();
            DataHoraVenda = DateTime.Now;
        }


        


        public bool EfetivarVenda()
        {
            Fechada = true;
            DataHoraVenda = DateTime.Now;
            return true;
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|               ID: " + Identificador);
            sb.AppendLine("|          Fechada: " + Fechada);
            //sb.AppendLine("|         Vendedor: " + Vendedor.Nome);
            //sb.AppendLine("|  Nome do Cliente: " + Cliente.Nome);
            //sb.AppendLine("|   NIF do Cliente: " + Cliente.NIF);
            //sb.AppendLine("|     Nome da Loja: " + PontoDeVenda.Loja.Nome);
            //sb.AppendLine("|    Local da Loja: " + PontoDeVenda.Loja.Local);
            //sb.AppendLine("|      NIF da Loja: " + PontoDeVenda.Loja.NIF);
            //sb.AppendLine("|              POS: " + PontoDeVenda.Nome);
            foreach(var item in DetalheVenda.ListaDeArtigos)
            {
                sb.AppendLine("+-----------------------------------------------------------------+");
                sb.AppendLine("|   Nome do Artigo: " + item.Nome);
                sb.AppendLine("|  Número de Série: " + item.NumeroSerie);
                sb.AppendLine("|   Preço Unitário: " + item.PrecoUnitario);
            }
            sb.AppendLine("+-----------------------------------------------------------------+");
            //sb.AppendLine("|            Total: " + DataHoraVenda);
            sb.AppendLine("|  Data/Hora Venda: " + DataHoraVenda);
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }

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
            foreach (var item in DetalheVenda.ListaDeArtigos)
            {
                sb.AppendLine($"{item.Nome} (NS: {item.NumeroSerie})   {item.PrecoUnitario} €/un ");
            }

            //Poderíamos escrever usando a notação LINQ
            //DetalheVenda.Produtos.Select(x => sb.AppendLine($"Nome: {x.Nome}  - Valor Unitario: {x.PrecoUnitario} - Número de Série: {x.NumeroSerie}"))
        }
    }
}