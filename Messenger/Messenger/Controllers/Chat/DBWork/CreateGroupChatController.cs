using Messenger.SQL.Builder.Builders.Chat;
using Messenger.SQL.CQRS.Chat.Command.Create;
using Messenger.SQL.CQRS.Chat.Create;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Chat.DBWork
{
    [ApiController]
    [Route("chats")]
    [ApiExplorerSettings(GroupName = "chats")]
    public class CreateGroupChatController : ControllerBase
    {
        private readonly ICreateChatCommandHandler _command;

        public CreateGroupChatController(ICreateChatCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("creategroup")]
        public async Task<IActionResult> Create([FromBody] CreateChatPartsCommand command)
        {
            CreateChatRecreator recreator = new CreateChatRecreator(_command);
            return await recreator.Execute(command, new GroupChatBuilder());
        }
    }
}
