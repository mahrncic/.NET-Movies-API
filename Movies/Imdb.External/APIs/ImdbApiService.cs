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
            var movies = await _imdbApi.SearchMovieAsync(keyword);

            return null;
        }
    }
}
