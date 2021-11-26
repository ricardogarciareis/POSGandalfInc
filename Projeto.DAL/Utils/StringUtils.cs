using System.Globalization;

namespace Projeto.DAL.Utils
{
    public static class StringUtils
    {
        public static string ToTitleCase(this string parametro)
        {
            TextInfo cultura = new CultureInfo("pt-PT", false).TextInfo;
            var resultado = cultura.ToTitleCase(parametro);
            return resultado;
        }
    }
}
