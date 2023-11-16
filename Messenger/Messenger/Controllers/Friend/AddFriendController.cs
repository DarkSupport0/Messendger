using Messenger.SQL.CQRS.User.AddFriend;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Friend
{
    [ApiController]
    [Route("friends")]
    [ApiExplorerSettings(GroupName = "friends")]
    public sealed class AddFriendController : ControllerBase
    {
        private readonly IAddFriendsCommandHandler _command;

        public AddFriendController(IAddFriendsCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create([FromBody] AddFriendsCommand command)
        {
            await _command.Handle(command);
            return Ok();
        }
    }
}
