using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movies.Application.DTOs;
using Movies.Application.Features.Requests;

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{keyword}")]
        public async Task<ActionResult<MovieResultDto>> GetMovies(string keyword)
        {
            var leaveTypes = await _mediator.Send(new GetMoviesRequest(keyword));
            return Ok(leaveTypes);
        }
    }
}
