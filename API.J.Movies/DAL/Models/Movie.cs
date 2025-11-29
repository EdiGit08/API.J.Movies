using System.ComponentModel.DataAnnotations;

namespace API.J.Movies.DAL.Models
{
    public class Movie : AuditBase
    {
        [Required] // este decorator indica que el campo es obligatorio (no acepta nulls)
        [MaxLength(100)] // este decorator indica la longitud maxima del campo
        public string Name { get; set; }

        [Required]
        public int Duration { get; set; }

        public string Description { get; set; }

        [Required]
        [MaxLength(10)]
        public string Clasification { get; set; }
    }
}
