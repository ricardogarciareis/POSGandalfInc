using System.Text;

namespace Projeto.Lib.Entidades
{
    public class Utilizador : Entidade
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public Utilizador()
        {

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|               ID: " + Identificador);
            sb.AppendLine("|            Ativo: " + Ativo);
            sb.AppendLine("|             Nome: " + Nome);
            sb.AppendLine("|         UserName: " + Email);
            sb.AppendLine("|         Password: " + Password);
            sb.AppendLine("|          Criação: " + DataCriacao);
            sb.AppendLine("| Última Alteração: " + DataAlteracao);
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }
    }
}
