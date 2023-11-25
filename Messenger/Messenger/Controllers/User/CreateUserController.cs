using Messenger.SQL.CQRS.User.Create;
using Messenger.SQL.CQRS.User.Query.FindUserById;
using Messenger.SQL.Dtos.User;
using Messenger.SQL.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.User
{
    [ApiController]
    [Route("users")]
    [ApiExplorerSettings(GroupName = "users")]
    public class CreateUserController : ControllerBase
    {
        private readonly ICreateUserCommandHandler _command;
        private readonly IMediator _mediator;

        public CreateUserController(ICreateUserCommandHandler command, IMediator mediator)
        {
            _command = command;
            _mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] UserMediatorDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid data");

            if (dto.Id != null)
            {
                UserMediatorInfoDto? info = await _mediator.Send<FindUserQueryById, UserMediatorInfoDto?>(new FindUserQueryById(dto.Id!));
                if (info != null)
                    return Ok("User with this Id was find.");
            }
            CreateUserCommand user = new(dto.Username, dto.Firstname, dto.Lastname, dto.Birthday, dto.Email, dto.Phone, dto.Country);
            try
            {
                await _mediator.Send(user);
                return Ok("User was created");
            }
            catch
            {
                return StatusCode(500, $"Something wrong");
            }
        }

    }
}
