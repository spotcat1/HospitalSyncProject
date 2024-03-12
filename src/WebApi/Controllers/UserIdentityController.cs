using Application.Contracts;
using Application.Dtos.UserDto;
using Application.Dtos.UserIdentityDto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Filters;
using static Application.Commands.UserIdentityCommand;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [CustomActionResultFilter]
    [ExceptionFilter]
    public class UserIdentityController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public UserIdentityController(IMediator mediator, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
        }

        [HttpPost("{RoleId}")]
        [ProducesResponseType(StatusCodes.Status200OK,Type =typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<Guid>> AddUserIdentity([FromForm] CreateUserIdentityDto Dto, Guid RoleId)
        {
            
             var command = new CreateUserIdentity(Dto, RoleId);
             var userId = await _mediator.Send(command);
             await _unitOfWork.CompleteAsync();
             return Ok(userId);
           
        }


    }
}
