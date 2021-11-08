using System.Text;

namespace Projeto.Lib.Entidades
{
    public class CategoriaArtigo : Entidade
    {
        public CategoriaArtigo()
        {
            
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|               ID: " + Identificador);
            sb.AppendLine("|            Ativo: " + Ativo);
            sb.AppendLine("|             Nome: " + Nome);
            sb.AppendLine("|          Criação: " + DataCriacao);
            sb.AppendLine("| Última Alteração: " + DataAlteracao);
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }
    }
}
