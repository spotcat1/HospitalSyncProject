
using Application.Commands;
using Application.Contracts;
using Application.Dtos.UserDto;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApi.Filters;

namespace WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    [CustomActionResultFilter]
    [ExceptionFilter]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IMediator mediator, IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]


        public async Task<ActionResult<Guid>> AddUserV1([FromForm] AddUpdateUserDto dto)
        {
            var ExistGender = await _userRepository.ExistGender(dto.GenderId);


            var IsUniqueIdentityCode = await _userRepository.IsUniqueIdentityCode(dto.IdentityCode, Guid.Empty);




            if (ExistGender && IsUniqueIdentityCode)
            {
                var Result = await _mediator.Send(new CreateUser(dto));
                await _unitOfWork.CompleteAsync();
                return Ok(Result);
            }

            return Guid.Empty;
        }



        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<string>> UpdateUserV1([FromRoute] Guid id, [FromForm] AddUpdateUserDto dto)
        {
            var ExistUser = await _userRepository.ExistUser(id);

            var GenderExist = await _userRepository.ExistGender(dto.GenderId);

            var IsUniqueIdentityCode = await _userRepository.IsUniqueIdentityCode(dto.IdentityCode, id);

            

            if (ExistUser && GenderExist && IsUniqueIdentityCode )
            {
                var Result = await _mediator.Send(new UpdateUser(dto, id));
                await _unitOfWork.CompleteAsync();
                return Ok(Result);
            }

            return "";
        }



        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<GetUserByIdDto>> GetUserByIdV1([FromRoute] Guid id, [FromQuery] bool? ShowIfIsDeleted)
        {
            var Result = await _mediator.Send(new GetUserById(id, ShowIfIsDeleted ?? false));
            return Ok(Result);
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<GetAllUsersDto>>> GetAllUsersV1([FromQuery] string? FirstFilterOn, [FromQuery] string? FirstFilterQuery,
            [FromQuery] string? SecondFilterOn, [FromQuery] string? SecondFilterQuery,
            [FromQuery] string? FirstOrderBy, [FromQuery] bool? FirstIsAscending,
            [FromQuery] string? SecondOrderBy, [FromQuery] bool? SecondIsAscending,
            [FromQuery] bool? ShowDeletedOnes,
            [FromQuery] int PageNumber = 1, [FromQuery] int PageSize = 100)
        {
            var Result = await _mediator.Send(new GetAllUsers(
                FirstFilterOn, FirstFilterQuery, SecondFilterOn, SecondFilterQuery,
                FirstOrderBy, FirstIsAscending ?? true, SecondOrderBy, SecondIsAscending ?? true,
                ShowDeletedOnes ?? false, PageNumber, PageSize
                ));


            return Ok(Result);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<GetAllUsersDto>>> GetAllUsersPaginated([FromQuery] int PageNumber = 1, [FromQuery] int PageSize=10)
        {
            var Result = await _mediator.Send(new GetAllPaginatedUsers(PageNumber, PageSize));

            return Ok(Result);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<string>> SoftDeleteUserV1([FromRoute] Guid id)
        {
            var Result = await _mediator.Send(new SoftDeleteUser(id));
            await _unitOfWork.CompleteAsync();
            return Ok(Result);
        }



        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<string>> DeleteUserV1([FromRoute] Guid id)
        {
            var Result = await _mediator.Send(new DeleteUser(id));
            await _unitOfWork.CompleteAsync();
            return Ok(Result);
        }


    }
}
