using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DAL.Model
{
    public abstract class Entidade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Identificador { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }

        
        //O que fazer?

        //public Entidade()
        //{
        //    Identificador = Guid.NewGuid();
        //    Ativo = true;
        //    DataCriacao = DateTime.Now;
        //}

        //public Entidade(string nome)
        //{
        //    Nome = nome;
        //    Identificador = Guid.NewGuid();
        //    Ativo = true;
        //    DataCriacao = DateTime.Now;
        //}

    }
}
