using System.ComponentModel.DataAnnotations;

namespace Projeto.DAL.Entidades
{
    public class Morada : Entidade
    {
        [MaxLength(255)]
        public string Endereco { get; set; }

        [Required]
        [MinLength(7), MaxLength(7)]
        public string CodigoPostal { get; set; }

        [Required]
        [MaxLength(255)]
        public string Localidade { get; set; }

        [MaxLength(255)]
        public string Distrito { get; set; }

        [MaxLength(255)]
        public string Observacoes { get; set; }  
    }
}
