using System;
using System.Text;

namespace Projeto.Lib.Entidades
{
    public class Artigo : Entidade
    {
        public CategoriaArtigo CategoriaArtigo { get; set; }
        public string ReferenciaEAN { get; set; }
        public string Fabricante { get; set; }
        public string NumeroSerie { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public decimal PrecoUnitario { get; set; }


        public Artigo()
        {
            
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|               ID: " + Identificador);
            sb.AppendLine("|            Ativo: " + Ativo);
            sb.AppendLine("|             Nome: " + Nome);
            //sb.AppendLine("|        Categoria: " + CategoriaArtigo.Nome);
            //sb.AppendLine("|       Referência: " + ReferenciaEAN);
            sb.AppendLine("|       Fabricante: " + Fabricante);
            sb.AppendLine("|  Número de Série: " + NumeroSerie);
            //sb.AppendLine("|       Fornecedor: " + Fornecedor.Nome);
            //Console.OutputEncoding = Encoding.UTF8;  //Utilizado para reconhecer o símbolo €
            //sb.AppendLine("|   Preço Unitário: € " + PrecoUnitario);
            //sb.AppendLine("|          Criação: " + DataCriacao);
            //sb.AppendLine("| Última Alteração: " + DataAlteracao);
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }
    }
}
