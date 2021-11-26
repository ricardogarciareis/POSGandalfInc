using System.ComponentModel.DataAnnotations;

namespace Projeto.DAL.Entidades
{
    public abstract class Pessoa : Entidade
    {
        [Required]
        [MinLength(9, ErrorMessage = "NIF com tamanho errado"), MaxLength(9, ErrorMessage = "NIF com tamanho errado")]
        public string NIF { get; set; }

        public Morada Morada { get; set; }

        public string Telefone { get; set; }

        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }

        protected Pessoa()
        {
            Morada = new Morada();
        }

    }
}
