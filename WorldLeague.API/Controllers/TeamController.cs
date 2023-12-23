using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorldLeague.API.Features.Commands.Teams.CreateTeam;
using WorldLeague.API.Features.Commands.Teams.DeleteTeam;
using WorldLeague.API.Features.Commands.Teams.UpdateTeam;
using WorldLeague.API.Features.Queries.Teams.GetAllTeam;
using WorldLeague.API.Features.Queries.Teams.GetByIdTeam;

namespace WorldLeague.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeamController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] GetAllTeamQueryRequest request)
        {
            GetAllTeamQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("by-id")]
        public async Task<IActionResult> GetByIdAsync([FromQuery] GetByIdTeamQueryRequest request)
        {
            GetByIdTeamQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateTeamCommandRequest request)
        {
            CreateTeamCommandResponse response = await _mediator.Send(request);
            return Created(string.Empty, response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UpdateTeamCommandRequest request)
        {
            UpdateTeamCommandResponse response = await _mediator.Send(request);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAsync([FromQuery] DeleteTeamCommandRequest request)
        {
            DeleteTeamCommandResponse response = await _mediator.Send(request);
            return NoContent();
        }
    }
}
