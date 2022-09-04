namespace Movies.Domain
{
    public record Movie(string Id, string ImageUrl, string Title, string Description, List<Trailer> Trailers);
}
