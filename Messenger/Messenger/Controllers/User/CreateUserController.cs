using Messenger.SQL.CQRS.User.Create;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.User
{
    [ApiController]
    [Route("users")]
    [ApiExplorerSettings(GroupName = "users")]
    public class CreateUserController : ControllerBase
    {
        private readonly ICreateUserCommandHandler _command;

        public CreateUserController(ICreateUserCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateUserCommand command)
        {
            await _command.Handle(command);
            return Ok();
        }
    }
}
