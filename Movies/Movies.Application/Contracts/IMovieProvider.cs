using Movies.Domain;

namespace Movies.Application.Contracts
{
    public interface IMovieProvider
    {
        Task<MovieResult> Get(string keyword);
    }
}
