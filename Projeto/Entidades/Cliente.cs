﻿using System.Text;

namespace Projeto.Lib.Entidades
{
    public class Cliente : Entidade
    {
        public string NIF { get; set; }

        public Cliente()
        {

        }

        public bool NIFValido()
        {
            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("|   ID: " + Identificador);
            sb.AppendLine("| Nome: " + Nome);
            sb.AppendLine("|  NIF: " + NIF);
            sb.Append("+-----------------------------------------------------------------+");
            return sb.ToString();
        }


    }
}
