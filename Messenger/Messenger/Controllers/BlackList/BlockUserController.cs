using Messenger.SQL.CQRS.Commands.User.BlockUser;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.BlackList
{
    [ApiController]
    [Route("blacklist")]
    [ApiExplorerSettings(GroupName = "blacklist")]
    public sealed class BlockUserController : ControllerBase
    {
        private readonly IBlockUserCommand _command;

        public BlockUserController(IBlockUserCommand command)
        {
            _command = command;
        }

        [HttpPost("block")]
        public async Task<IActionResult> Create([FromBody] BlockUserDto dto)
        {
            await _command.Execute(dto);
            return Ok();
        }
    }
}
