using Messenger.PostgreSQL.Commands.Chat.Create;
using Microsoft.AspNetCore.Mvc;
using Messenger.RestModels.Friends;

namespace Messenger.Controllers.Chat;

[ApiController]
[Route("Chat")]
[ApiExplorerSettings(GroupName = "Chat")]
public sealed class CreateChatController : ControllerBase
{
    private readonly ICreateChatCommand _createChat;

    public CreateChatController(ICreateChatCommand createChat)
    {
        _createChat = createChat;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] AddFriendsRequest request)
    {
        // validate user
        // handle user validation result

        CreateChatDto dto = new CreateChatDto();
        await _createChat.Execute(dto);

        return Ok();
    }
}