namespace Movies.Domain
{
    public class Trailer
    {
        public string? Id { get; init; }
        public string? Url { get { return $"https://www.youtube.com/watch?v={Id}"; } }
    }
}
