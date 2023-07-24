using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatorio")]
        public string Nome { get; set; }    

        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
