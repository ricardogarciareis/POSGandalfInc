using System.ComponentModel.DataAnnotations;

namespace Projeto.DAL.Entidades
{
    public class Artigo : Entidade
    {
        public virtual CategoriaArtigo CategoriaArtigo { get; set; }

        [Required]
        [MaxLength(255)]
        public string ReferenciaEAN { get; set; }

        [Required]
        [MaxLength(255)]
        public string Fabricante { get; set; }

        [MaxLength(255)]
        public string NumeroSerie { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }

        [Required]
        [Range(0, 1000000)]
        public decimal PrecoUnitario { get; set; }


        //O que fazer?

        //public Artigo()
        //{

        //}

        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.AppendLine("|               ID: " + Id);
        //    sb.AppendLine("|            Ativo: " + Ativo);
        //    sb.AppendLine("|             Nome: " + Nome);
        //    //sb.AppendLine("|        Categoria: " + CategoriaArtigo.Nome);
        //    //sb.AppendLine("|       Referência: " + ReferenciaEAN);
        //    sb.AppendLine("|       Fabricante: " + Fabricante);
        //    sb.AppendLine("|  Número de Série: " + NumeroSerie);
        //    //sb.AppendLine("|       Fornecedor: " + Fornecedor.Nome);
        //    //Console.OutputEncoding = Encoding.UTF8;  //Utilizado para reconhecer o símbolo €
        //    //sb.AppendLine("|   Preço Unitário: € " + PrecoUnitario);
        //    //sb.AppendLine("|          Criação: " + DataCriacao);
        //    //sb.AppendLine("| Última Alteração: " + DataAlteracao);
        //    sb.Append("+-----------------------------------------------------------------+");
        //    return sb.ToString();
        //}
    }
}
