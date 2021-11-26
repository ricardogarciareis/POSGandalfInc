using Projeto.DAL.Faturacao;
using Projeto.Lib.Infraestrutura;
using System.Text;

namespace Projeto.Lib.Faturacao
{
    public class LogicaDeVenda : IImpressora
    {
        //Injeção de Dependência
        private Venda _venda { get; set; }
        public LogicaDeVenda(Venda venda)
        {
            _venda = venda;
        }

        public void GerarRecibo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Fatura Recibo FRD {_venda.DataHoraVenda.Year}/{_venda.NumeroSerie}");
            sb.AppendLine($"Loja: {_venda.PontoDeVenda.Loja.NIF} - Ponto de Venda: {_venda.PontoDeVenda.Id} ");
            sb.AppendLine($"Loja: {_venda.PontoDeVenda.Loja.Morada}");
            sb.AppendLine($"Vendedor: {_venda.Vendedor.Nome} Identificador: {_venda.Vendedor.Id} ");
            sb.AppendLine($"Data da Fatura/Recibo: {_venda.DataHoraVenda} ");
            sb.AppendLine($"Tipo Pagamento: {_venda.TipoPagamento} "); //TODO: Trocar enumerador por string
            sb.AppendLine($"Valor Pagamento: {_venda.ValorPagamento} ");
            foreach (var item in _venda.DetalheVenda.ListaDeArtigos)
            {
                sb.AppendLine($"{item.Nome} (NS: {item.NumeroSerie})   {item.PrecoUnitario} €/un ");
            }

            //    //Poderíamos escrever usando a notação LINQ
            //    //DetalheVenda.Produtos.Select(x => sb.AppendLine($"Nome: {x.Nome}  - Valor Unitario: {x.PrecoUnitario} - Número de Série: {x.NumeroSerie}"))
        }

        //public Venda()
        //{
        //    Id = Guid.NewGuid();
        //    Fechada = false;
        //    DetalheVenda = new DetalheDeVenda();
        //    DataHoraVenda = DateTime.Now;
        //}

        //public bool EfetivarVenda()
        //{
        //    Fechada = true;
        //    DataHoraVenda = DateTime.Now;
        //    return true;
        //}
    }
}