using DataProvider.External.APIs;
using Movies.Application.Contracts;
using Movies.Domain;

namespace DataProvider.External
{
    public class MovieProvider : IMovieProvider
    {
        private readonly ImdbApiService _imdbService;
        private readonly YouTubeApiService _youTubeApiService;

        public MovieProvider(ImdbApiService imdbService, YouTubeApiService youTubeApiService)
        {
            _imdbService = imdbService;
            _youTubeApiService = youTubeApiService;
        }

        public async Task<MovieResult> Get(string keyword)
        {
            var movies = await _imdbService.GetMovies(keyword);

            foreach(var movie in movies)
            {
                movie.Trailers = await _youTubeApiService.GetTrailersForMovie(movie.Title!);
            }

            return new MovieResult()
            {
                Movies = movies
            };
        }
    }
}
