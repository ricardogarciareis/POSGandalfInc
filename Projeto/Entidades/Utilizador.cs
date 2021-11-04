using System.Text;

namespace Projeto.Lib.Entidades
{
    public class Utilizador : Entidade
    {
        public string NIF { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Utilizador()
        {

        }

        public bool NIFValido()
        {
            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|       ID: " + Identificador);
            sb.AppendLine("|     Nome: " + Nome);
            sb.AppendLine("|      NIF: " + NIF);
            sb.AppendLine("| UserName: " + UserName);
            sb.AppendLine("| Password: " + Password);
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }


    }
}
