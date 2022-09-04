namespace Movies.Domain
{
    public class Trailer
    {
        public string? Id { get; set; }
        public string? Url { get { return $"https://www.youtube.com/watch?v={Id}"; } }
    }
}
