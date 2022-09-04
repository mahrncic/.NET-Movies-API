namespace Movies.Domain
{
    public record Trailer
    {
        public string? Id { get; init; }
        public string? Url { get { return $"https://www.youtube.com/watch?v={Id}"; } }
    }
}
