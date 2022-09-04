using MediatR;
using Movies.Application.DTOs;

namespace Movies.Application.Features.Requests
{
    public class GetMoviesRequest: IRequest<MovieResultDto>
    {
        public string Keyword { get; set; } = string.Empty;
    }
}
