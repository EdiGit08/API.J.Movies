using API.J.Movies.DAL.Dtos.Movie;
using API.J.Movies.DAL.Models;
using API.J.Movies.Repository.IRepository;
using API.J.Movies.Services.IServices;
using AutoMapper;
using System.Collections;

namespace API.J.Movies.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public Task<bool> MovieExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> MovieExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<MovieDto> CreateMovieAsync(MovieCreateUpdateDto movieCreateDto)
        {
            //Validar si la pelicula ya existe
            var movieExists = await _movieRepository.MovieExistsByNameAsync(movieCreateDto.Name);

            if (movieExists)
            {
                throw new InvalidOperationException($"Ya existe una pelicula con el nombre de '{movieCreateDto.Name}'");
            }

            //Mapear el DTO a la entidad
            var movie = _mapper.Map<Movie>(movieCreateDto);

            //Crear la pelicula en el repositorio
            var movieCreated = await _movieRepository.CreateMovieAsync(movie);

            if (!movieCreated)
            {
                throw new Exception("Ocurrió un error al crear la pelicula.");
            }

            //Mapear la entidad creada a DTO
            return _mapper.Map<MovieDto>(movie);
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            await GetMovieByIdAsync(id);

            var isDeleted = await _movieRepository.DeleteMovieAsync(id);

            if (!isDeleted)
            {
                throw new Exception("Ocurrió un error al eliminar la pelicula.");
            }

            return isDeleted;
        }

        public async Task<ICollection<MovieDto>> GetMoviesAsync()
        {
            // Obtener las peliculas del repositorio
            var movies = await _movieRepository.GetMoviesAsync();

            // Mapear toda la colección de una vez
            return _mapper.Map<ICollection<MovieDto>>(movies);
        }

        public async Task<MovieDto> GetMovieAsync(int id)
        {
            // Obtener la pelicula del repositorio
            var movie = await GetMovieByIdAsync(id);

            // Mapear toda la colección de una vez
            return _mapper.Map<MovieDto>(movie);
        }

        public async Task<MovieDto> UpdateMovieAsync(MovieCreateUpdateDto dto, int id)
        {
            //Verificar si la pelicula existe
            var existingMovie = await GetMovieByIdAsync(id);

            var nameExists = await _movieRepository.MovieExistsByNameAsync(dto.Name);
            if (nameExists)
            {
                throw new InvalidOperationException($"Ya existe una pelicula con el nombre de '{dto.Name}'");
            }

            //Mapear los cambios del DTO a la entidad existente Movie
            _mapper.Map(dto, existingMovie);

            //Actualizar la pelicula en el repositorio
            var isUpdated = await _movieRepository.UpdateMovieAsync(existingMovie);

            if (!isUpdated)
            {
                throw new Exception("Ocurrió un error al actualizar la pelicula.");
            }

            //retornar el MovieDto actualizado
            return _mapper.Map<MovieDto>(existingMovie);
        }

        private async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movie = await _movieRepository.GetMovieAsync(id);

            if (movie == null)
            {
                throw new InvalidOperationException($"No se encontró la pelicula con ID: '{id}'");
            }

            return movie;
        }
    }
}
