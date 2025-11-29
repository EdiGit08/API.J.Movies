using API.J.Movies.DAL.Models;

namespace API.J.Movies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMoviesAsync(); //Me retorna una lista de peliculas
        Task<Movie> GetMovieAsync(int id); //Me retorna una pelicula en especifico
        Task<bool> MovieExistsByIdAsync(int id); //Verifica si una pelicula existe por id
        Task<bool> MovieExistsByNameAsync(string name); //Verifica si una pelicula existe por nombre
        Task<bool> CreateMovieAsync(Movie movie); //Crea una nueva pelicula
        Task<bool> UpdateMovieAsync(Movie movie); //Actualiza una pelicula
        Task<bool> DeleteMovieAsync(int id); //Elimina una pelicula buscando por id
    }
}
