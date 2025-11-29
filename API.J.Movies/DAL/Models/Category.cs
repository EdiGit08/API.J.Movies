using System.ComponentModel.DataAnnotations;

namespace API.J.Movies.DAL.Models
{
    public class Category : AuditBase
    {
        [Required] // este decorator indica que el campo es obligatorio (no acepta nulls)
        public string Name { get; set; }
    }
}
