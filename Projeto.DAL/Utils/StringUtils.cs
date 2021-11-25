using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
