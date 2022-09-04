namespace Movies.Application.DTOs
{
    public record MovieDto(string Id, string ImageUrl, string Title, string Description, List<TrailerDto> Trailers);

}
