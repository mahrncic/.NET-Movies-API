namespace Movies.Application.DTOs
{
    public record MovieDto
    {
        public string? Id { get; set; }
        public string? ImageUrl { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public ICollection<TrailerDto>? Trailers { get; set; }
    }
}
