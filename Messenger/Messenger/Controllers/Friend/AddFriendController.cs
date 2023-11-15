using Messenger.SQL.CQRS.Commands.User.AddFriend;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Friend
{
    [ApiController]
    [Route("friends")]
    [ApiExplorerSettings(GroupName = "friends")]
    public sealed class AddFriendController : ControllerBase
    {
        private readonly IAddFriendsCommand _command;

        public AddFriendController(IAddFriendsCommand command)
        {
            _command = command;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create([FromBody] AddFriendsDto dto)
        {
            await _command.Execute(dto);
            return Ok();
        }
    }
}
