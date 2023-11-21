using Messenger.SQL.CQRS.Chat.Create;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Chat.DBWork
{
    [ApiController]
    [Route("chats")]
    [ApiExplorerSettings(GroupName = "chats")]
    public class CreateChatController : ControllerBase
    {
        private readonly ICreateChatCommandHandler _command;

        public CreateChatController(ICreateChatCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateChatCommand command)
        {
            await _command.Handle(command);
            return Ok();
        }
    }
}
