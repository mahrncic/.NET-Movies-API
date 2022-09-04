using AutoMapper;
using Movies.Application.DTOs;
using Movies.Domain;

namespace Movies.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Trailer, TrailerDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<MovieResult, MovieResultDto>();
        }
    }
}
