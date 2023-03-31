using Clinical.Application.UseCases.UseCases.Analysis.Queries.GetAllQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clinical.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalysisController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AnalysisController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListAnalysis()
        {
            var response = await _mediator.Send(new GetAllAnalysisQuery());
            return Ok(response);
        }
    }
}
