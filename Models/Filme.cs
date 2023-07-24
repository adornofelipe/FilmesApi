using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get;  set; }
        [Required(ErrorMessage = "Titulo do filme é obrigatorio")]/* Obrigatorio*/
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Genero do filme é obrigatorio")]/* Obrigatorio*/
        [MaxLength(50, ErrorMessage = "O tamanho do genero não pode exceder 30 caracteres")]
        public string Genero { get; set; }

        [Range(70,600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
        [Required(ErrorMessage = "Duração do filme é obrigatorio")]/* Obrigatorio*/
        public int Duracao { get; set; }
       
    }

}
