using Projeto.DAL.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DAL.Model
{
    public abstract class Entidade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
     
        private string nome;
        [Required]
        [MaxLength(255)]
        public virtual string Nome
        {
            get { return nome; }
            set { //nome = value.ToUpper();
                //nome = StringUtils.ToTitleCase(value);
                nome = value.ToTitleCase(); 
            }
        }

        public bool Ativo { get; set; } = true;

        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        
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
