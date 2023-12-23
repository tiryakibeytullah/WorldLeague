using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorldLeague.API.Features.Commands.DrawReports.CreateDrawReport;

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

        [HttpPost]
        [Route("draw-lost")]
        public async Task<IActionResult> CreateDrawLostAsync(CreateDrawReportCommandRequest request)
        {
            CreateDrawReportCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
