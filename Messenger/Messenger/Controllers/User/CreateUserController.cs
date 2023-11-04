using Messenger.SQL.Commands.User.Create;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.User
{
    [ApiController]
    [Route("users")]
    [ApiExplorerSettings(GroupName = "users")]
    public class CreateUserController : ControllerBase
    {
        private readonly ICreateUserCommand _command;

        public CreateUserController(ICreateUserCommand command)
        {
            _command = command;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateUserDto dto)
        {
            await _command.Execute(dto);
            return Ok();
        }
    }
}
