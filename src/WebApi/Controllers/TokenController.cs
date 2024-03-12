using Application.Dtos.Identity;
using Application.Wrappers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Filters;
using static Application.Queries.TokendentityQueries;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [CustomActionResultFilter]
    [ExceptionFilter]

    public class TokenController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TokenController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [ProducesResponseType(typeof(CustomActionResult), StatusCodes.Status400BadRequest)]

        public async Task<ActionResult> GetToken([FromBody] GetTokenDto dto)
        {
            return Ok(await _mediator.Send(new GetTokenQuery(dto)));
        }
    }
}
