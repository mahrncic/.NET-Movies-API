namespace Movies.Domain
{
    public class Movie
    {
        public string? Id { get; set; }
        public string? ImageUrl { get; set; }
        public string? Title { get; set; }
        public List<string>? Trailers { get; set; }
    }
}
