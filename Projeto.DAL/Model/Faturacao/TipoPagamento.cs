using System.ComponentModel;

namespace Projeto.DAL.Model
{
    public enum TipoPagamento
    {
        [Description("Indefinido")]
        Indefinido = 0,
        [Description("Multibanco")]
        Multibanco = 1,
        [Description("Dinheiro")]
        Dinheiro = 2,
        [Description("MBWay")]
        MBWay = 3
    }
}
