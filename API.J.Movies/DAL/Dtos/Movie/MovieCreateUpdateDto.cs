using System.ComponentModel.DataAnnotations;

namespace API.J.Movies.DAL.Dtos.Movie
{
    public class MovieCreateUpdateDto
    {
        [Required(ErrorMessage = "El nombre de la pelicula es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre de la pelicula no puede exceder los 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La duracion de la pelicula es obligatorio")]
        public int Duration { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "La clasificacion de la pelicula es obligatorio")]
        [MaxLength(10, ErrorMessage = "La clasificacion de la pelicula no puede exceder los 10 caracteres")]
        public string Clasification { get; set; }
    }
}
