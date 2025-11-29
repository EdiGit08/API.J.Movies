using API.J.Movies.DAL.Dtos.Category;
using API.J.Movies.DAL.Dtos.Movie;
using API.J.Movies.DAL.Models;
using AutoMapper;

namespace API.J.Movies.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateUpdateDto>().ReverseMap();
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<Movie, MovieCreateUpdateDto>().ReverseMap();
        }
    }
}
