using System.ComponentModel.DataAnnotations;

namespace API.J.Movies.DAL.Models
{
    public class AuditBase
    {
        //Decorators o Data Annotations
        [Key] //PK
        public virtual int Id { get; set; } //PK de todas las tablas
        public virtual DateTime CreatedDate { get; set; } //este me sirve para guardar la fecha de creaciòn de un registro en BD
        public virtual DateTime? ModifiedDate { get; set; } //para guardar la fecha de modificaciòn de un registro en BD
    }
}
