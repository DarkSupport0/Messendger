using Messenger.SQL.CQRS.User.AddToChat;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Chat
{
    [ApiController]
    [Route("chats")]
    [ApiExplorerSettings(GroupName = "chats")]
    public sealed class AddToChatController : ControllerBase
    {
        private readonly IAddToChatCommandHandler _command;

        public AddToChatController(IAddToChatCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create([FromBody] AddToChatCommand command)
        {
            await _command.Handle(command);
            return Ok();
        }
    }
}
