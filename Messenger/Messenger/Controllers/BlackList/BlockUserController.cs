using Messenger.SQL.CQRS.User.BlockUser;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.BlackList
{
    [ApiController]
    [Route("blacklist")]
    [ApiExplorerSettings(GroupName = "blacklist")]
    public sealed class BlockUserController : ControllerBase
    {
        private readonly IBlockUserCommandHandler _command;

        public BlockUserController(IBlockUserCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("block")]
        public async Task<IActionResult> Create([FromBody] BlockUserCommand command)
        {
            await _command.Handle(command);
            return Ok();
        }
    }
}
