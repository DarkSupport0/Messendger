using Messenger.SQL.Commands.Chat.Create;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Chat
{
    [ApiController]
    [Route("chats")]
    [ApiExplorerSettings(GroupName = "chats")]
    public class CreateChatController : ControllerBase
    {
        private readonly ICreateChatCommand _command;

        public CreateChatController(ICreateChatCommand command)
        {
            _command = command;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateChatDto dto)
        {
            await _command.Execute(dto);
            return Ok();
        }
    }
}
