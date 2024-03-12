using Application.Commands;
using Application.Dtos.RolesDto;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Filters;
using static Application.Queries.RoleIdentityQueries;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [CustomActionResultFilter]
    [ExceptionFilter]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class RolesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RolesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Guid>> AddRole([FromBody] RoleDto roleDto)
        {

            return Ok(await _mediator.Send(new CreateRole(roleDto)));
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]


        public async Task<ActionResult<string>> UpdateRole([FromRoute] Guid id, [FromBody] RoleDto dto)
        {
            return Ok(await _mediator.Send(new UpdateRole(id, dto)));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> DeleteRole([FromRoute] Guid id)
        {

            return Ok(await _mediator.Send(new DeleteRole(id)));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RoleDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RoleDto>> GetRole([FromRoute] Guid id)
        {

            return Ok(await _mediator.Send(new GetRoleById(id)));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<RoleDto>))]
        public async Task<ActionResult<List<RoleDto>>> GetAllRoles([FromQuery] int PageNumber = 1,
            [FromQuery] int PageSize = 10)
        {
         
            return Ok(await _mediator.Send(new GetRoles(PageNumber,PageSize))); 
        }


    }
}
