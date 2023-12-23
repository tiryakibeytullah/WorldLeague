using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorldLeague.API.Features.Commands.Groups.CreateGroup;
using WorldLeague.API.Features.Commands.Groups.DeleteGroup;
using WorldLeague.API.Features.Commands.Groups.UpdateGroup;
using WorldLeague.API.Features.Queries.Groups.GetAllGroup;
using WorldLeague.API.Features.Queries.Groups.GetByIdGroup;

namespace WorldLeague.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GroupController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] GetAllGroupQueryRequest request)
        {
            GetAllGroupQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("by-id")]
        public async Task<IActionResult> GetByIdAsync([FromQuery] GetByIdGroupQueryRequest request)
        {
            GetByIdGroupQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateGroupCommandRequest request)
        {
            CreateGroupCommandResponse response = await _mediator.Send(request);
            return Created(string.Empty, response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UpdateGroupCommandRequest request)
        {
            UpdateGroupCommandResponse response = await _mediator.Send(request);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAsync([FromQuery] DeleteGroupCommandRequest request)
        {
            DeleteGroupCommandResponse response = await _mediator.Send(request);
            return NoContent();
        }
    }
}
