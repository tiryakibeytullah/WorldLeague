using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorldLeague.API.Features.Commands.Countries.CreateCountry;
using WorldLeague.API.Features.Commands.Countries.DeleteCountry;
using WorldLeague.API.Features.Commands.Countries.UpdateCountry;
using WorldLeague.API.Features.Queries.Countries.GetAllCountry;
using WorldLeague.API.Features.Queries.Countries.GetAllCountryWithNavigationProperties;
using WorldLeague.API.Features.Queries.Countries.GetByIdCountry;

namespace WorldLeague.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] GetAllCountryQueryRequest request)
        {
            GetAllCountryQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("by-id")]
        public async Task<IActionResult> GetByIdAsync([FromQuery] GetByIdCountryQueryRequest request)
        {
            GetByIdCountryQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("with-navigation-properties")]
        public async Task<IActionResult> GetWithNavigationPropertiesAsync([FromQuery] GetAllCountryWithNavigationPropertiesQueryRequest request)
        {
            GetAllCountryWithNavigationPropertiesQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateCountryCommandRequest request)
        {
            CreateCountryCommandResponse response = await _mediator.Send(request);
            return Created(string.Empty, response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UpdateCountryCommandRequest request)
        {
            UpdateCountryCommandResponse response = await _mediator.Send(request);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAsync([FromQuery] DeleteCountryCommandRequest request)
        {
            DeleteCountryCommandResponse response = await _mediator.Send(request);
            return NoContent();
        }
    }
}
