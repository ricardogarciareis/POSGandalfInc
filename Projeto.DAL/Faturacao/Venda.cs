using Projeto.DAL.Entidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DAL.Faturacao
{
    public class Venda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public bool Fechada { get; set; }
        public Utilizador Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public PontoDeVenda PontoDeVenda { get; set; }
        public DateTime DataHoraVenda { get; set; }
        public int NumeroSerie { get; set; }
        public TipoPagamento TipoPagamento { get; set; }

        //private string _tipoPagamentoDescricao;
        //public string TipoPagamentoDescricao
        //{
        //    get { return _tipoPagamentoDescricao; }
        //    set { 
        //        var resultado = "";
        //        switch (TipoPagamento)
        //        {
        //            case TipoPagamento.Indefinido:
        //                resultado = "Indefinido";
        //                break;
        //            case TipoPagamento.Multibanco:
        //                resultado = "Multibanco";
        //                break;
        //            case TipoPagamento.Dinheiro:
        //                resultado = "Dinheiro";
        //                break;
        //            case TipoPagamento.MBWay:
        //                resultado = "MBWay";
        //                break;
        //            default:
        //                break;
        //        }
        //          _tipoPagamentoDescricao = resultado; }
        //}

        public decimal ValorPagamento { get; set; }
        public DetalheDeVenda DetalheVenda { get; set; }

    }
}