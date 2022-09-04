namespace Movies.Application.DTOs
{
    public record TrailerDto
    {
        public string? Id { get; init; }
        public string? Url { get { return $"https://www.youtube.com/watch?v={Id}"; } }
    }
}
