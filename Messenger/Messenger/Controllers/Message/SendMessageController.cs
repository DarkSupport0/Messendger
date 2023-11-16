using Messenger.SQL.CQRS.Message.Send;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Message
{
    [ApiController]
    [Route("massages")]
    [ApiExplorerSettings(GroupName = "massages")]
    public sealed class SendMessageController : ControllerBase
    {
        private readonly ISendMessageCommandHandler _command;

        public SendMessageController(ISendMessageCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("send")]
        public async Task<IActionResult> Create([FromBody] SendMessageCommand command)
        {
            await _command.Handle(command);
            return Ok();
        }
    }
}
