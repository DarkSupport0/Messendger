using Messenger.SQL.CQRS.Commands.Message.Send;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Message
{
    [ApiController]
    [Route("massages")]
    [ApiExplorerSettings(GroupName = "massages")]
    public sealed class SendMessageController : ControllerBase
    {
        private readonly ISendMessageCommand _command;

        public SendMessageController(ISendMessageCommand command)
        {
            _command = command;
        }

        [HttpPost("send")]
        public async Task<IActionResult> Create([FromBody] SendMessageDto dto)
        {
            await _command.Execute(dto);
            return Ok();
        }
    }
}
