using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorldLeague.API.Features.Commands.DrawReports.CreateDrawReport;
using WorldLeague.API.Features.Queries.DrawReports.GetByIdDrawReport;

namespace WorldLeague.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawReportController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DrawReportController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("by-user")]
        public async Task<IActionResult> GetByUserAsync([FromQuery] GetByUserDrawReportQueryRequest request)
        {
            GetByUserDrawReportQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("draw-lost")]
        public async Task<IActionResult> CreateDrawLostAsync(CreateDrawReportCommandRequest request)
        {
            CreateDrawReportCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
