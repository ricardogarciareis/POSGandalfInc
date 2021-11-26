using Projeto.DAL.Faturacao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto.DAL.Entidades
{
    public class Cliente : Pessoa
    {
        [Display(Name = "Nome do Cliente")]
        public override string Nome
        {
            get => base.Nome;
            set => base.Nome = value;
        }

        [Range(typeof(DateTime), "1/1/1900", "1/1/2100",
        ErrorMessage = "Data para {0} deve situar-se entre {1} e {2}")]
        public DateTime? DataNascimento { get; set; }

        public virtual List<Venda> Compras { get; set; }


        //O que fazer?

        //public Cliente()
        //{

        //}

        //public static bool NIFValido()
        //{
        //    return false;
        //}

        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.AppendLine("|               ID: " + Id);
        //    sb.AppendLine("|            Ativo: " + Ativo);
        //    sb.AppendLine("|       Designação: " + Nome);
        //    sb.AppendLine("|              NIF: " + NIF);
        //    sb.AppendLine("|  Data Nascimento: " + DataNascimento.ToString("dd/MM/yyyy"));
        //    sb.AppendLine("|         Endereço: " + MoradaPessoa.Endereco);
        //    //sb.AppendLine("|    Código Postal: " + Morada.CodigoPostal);
        //    //sb.AppendLine("|       Localidade: " + Morada.Localidade);
        //    //sb.AppendLine("|      Observações: " + Morada.Observacoes);
        //    sb.AppendLine("|         Telefone: " + Telefone);
        //    sb.AppendLine("|            Email: " + Email);
        //    sb.AppendLine("|          Criação: " + DataCriacao);
        //    sb.AppendLine("| Última Alteração: " + DataAlteracao);
        //    sb.Append("+-----------------------------------------------------------------+");
        //    return sb.ToString();
        //}


    }
}
