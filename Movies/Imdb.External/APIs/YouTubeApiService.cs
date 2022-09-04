using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.Extensions.Configuration;
using Movies.Domain;

namespace DataProvider.External.APIs
{
    public class YouTubeApiService
    {
        private readonly YouTubeService _youTubeService;
        private readonly IConfiguration _config;

        public YouTubeApiService(IConfiguration configuration)
        {
            _config = configuration;

            _youTubeService =  new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = _config["YouTubeAPI:APIKey"],
                ApplicationName = _config["YouTubeAPI:AppName"]
            });
        }

        public async Task<ICollection<Trailer>> GetTrailersForMovie(string movieName)
        {
            var searchRequest = GetYouTubeRequest(movieName);
            var response = await searchRequest.ExecuteAsync();

            return null;
        }

        private SearchResource.ListRequest GetYouTubeRequest(string movieName)
        {
            var searchRequest = _youTubeService.Search.List("snippet");
            searchRequest.Q = $"Trailer {movieName}";
            searchRequest.MaxResults = Int32.Parse(_config["YouTubeAPI:MaxResults"]);

            return searchRequest;
        }
    }
}
