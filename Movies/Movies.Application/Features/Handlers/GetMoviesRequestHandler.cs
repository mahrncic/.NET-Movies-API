using AutoMapper;
using MediatR;
using Movies.Application.Contracts;
using Movies.Application.DTOs;
using Movies.Application.Features.Requests;

namespace Movies.Application.Features.Handlers
{
    public class GetMoviesRequestHandler : IRequestHandler<GetMoviesRequest, MovieResultDto>
    {
        private readonly IMapper _mapper;
        private readonly IMovieProvider _movieProvider;

        public GetMoviesRequestHandler(IMapper mapper, IMovieProvider movieProvider)
        {
            _mapper = mapper;
            _movieProvider = movieProvider;
        }

        public async Task<MovieResultDto> Handle(GetMoviesRequest request, CancellationToken cancellationToken)
        {
            var movieResult = await _movieProvider.Get(request.Keyword);
            return _mapper.Map<MovieResultDto>(movieResult);
        }
    }
}
