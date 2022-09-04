using IMDbApiLib;
using Microsoft.Extensions.Configuration;
using Movies.Domain;

namespace DataProvider.External.APIs
{
    public class ImdbApiService
    {
        private readonly ApiLib _imdbApi;

        public ImdbApiService(IConfiguration configuration)
        {
            _imdbApi = new ApiLib(configuration["ImdbAPI:APIKey"]);
        }

        public async Task<ICollection<Movie>> GetMovies(string keyword)
        {
            var response = await _imdbApi.SearchMovieAsync(keyword);

            var movies = response.Results.Select(x => new Movie()
            {
                Id = x.Id,
                ImageUrl = x.Image,
                Title = x.Title
            }).ToList();

            return movies;
        }
    }
}
