using System.ComponentModel.DataAnnotations;

namespace Projeto.DAL.Model
{
    public abstract class Pessoa : Entidade
    {
        [Required]
        [MinLength(9), MaxLength(9)]
        public string NIF { get; set; }

        public virtual Morada MoradaPessoa { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        //O que fazer?

        //public Pessoa()
        //{
        //    MoradaPessoa = new Morada();

        //}
    }
}
