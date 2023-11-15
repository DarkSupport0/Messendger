using Messenger.SQL.CQRS.Commands.User.AddToChat;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Chat
{
    [ApiController]
    [Route("chats")]
    [ApiExplorerSettings(GroupName = "chats")]
    public sealed class AddToChatController : ControllerBase
    {
        private readonly IAddToChatCommand _command;

        public AddToChatController(IAddToChatCommand command)
        {
            _command = command;
        }

        [HttpPost("addUserToChat")]
        public async Task<IActionResult> Create([FromBody] AddToChatDto dto)
        {
            await _command.Execute(dto);
            return Ok();
        }
    }
}
