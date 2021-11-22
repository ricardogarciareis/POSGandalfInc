using System.ComponentModel.DataAnnotations;

namespace Projeto.DAL.Model
{
    public class Morada : Entidade
    {
        [Required]
        [MaxLength(255)]
        public string Endereco { get; set; }

        [Required]
        [MinLength(7), MaxLength(7)]
        public string CodigoPostal { get; set; }

        [Required]
        [MaxLength(255)]
        public string Localidade { get; set; }

        [Required]
        [MaxLength(255)]
        public string Distrito { get; set; }

        [MaxLength(255)]
        public string Observacoes { get; set; }  
    }
}
