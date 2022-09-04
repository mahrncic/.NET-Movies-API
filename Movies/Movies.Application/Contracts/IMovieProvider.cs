using Movies.Application.DTOs;

namespace Movies.Application.Contracts
{
    public interface IMovieProvider
    {
        Task<MovieResultDto> Get(string keyword);
    }
}
