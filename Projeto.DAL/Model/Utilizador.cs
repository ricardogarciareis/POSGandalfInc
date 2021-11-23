using System.ComponentModel.DataAnnotations;

namespace Projeto.DAL.Model
{
    public class Utilizador : Entidade
    {
        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }


        //O que fazer?

        //public Utilizador()
        //{

        //}

        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.AppendLine("|               ID: " + Id);
        //    sb.AppendLine("|            Ativo: " + Ativo);
        //    sb.AppendLine("|             Nome: " + Nome);
        //    sb.AppendLine("|         UserName: " + Email);
        //    sb.AppendLine("|         Password: " + Password);
        //    sb.AppendLine("|          Criação: " + DataCriacao);
        //    sb.AppendLine("| Última Alteração: " + DataAlteracao);
        //    sb.Append("+-----------------------------------------------------------------+");
        //    return sb.ToString();
        //}
    }
}
