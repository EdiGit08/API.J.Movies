using System.ComponentModel.DataAnnotations;

namespace API.J.Movies.DAL.Dtos.Category
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la categoría es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre de la categoría no puede exceder los 100 caracteres")]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
