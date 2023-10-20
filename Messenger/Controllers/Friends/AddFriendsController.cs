using Messenger.PostgreSQL.Commands.Friend.Add;
using Messenger.RestModels.Friends;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Friends;

[ApiController]
[Route("Friends")]
[ApiExplorerSettings(GroupName = "Friends")]
public sealed class AddFriendsController : ControllerBase
{
    private readonly IAddFriendCommand _addFriend;

    public AddFriendsController(IAddFriendCommand addFriend)
    {
        _addFriend = addFriend;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Create([FromBody] AddFriendsRequest request)
    {
        // validate user
        // handle user validation result

        AddFriendDto dto = new AddFriendDto();
        await _addFriend.Execute(dto);

        return Ok();
    }
}