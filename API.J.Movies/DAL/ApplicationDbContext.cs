using API.J.Movies.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace API.J.Movies.DAL
{
    public class ApplicationDbContext : DbContext
    {
        //constructor: para poder inicializar la clase base DbContext en otras palabras, virtualizar mi BD
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Definir los DbSets (tablas) que voy a utilizar en mi aplicaciòn
        public DbSet<Category> Categories { get; set; }
    }
}
