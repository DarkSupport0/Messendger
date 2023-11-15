using Messenger.SQL.CQRS.Commands.Message.Edit;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Message
{
    [ApiController]
    [Route("massages")]
    [ApiExplorerSettings(GroupName = "massages")]
    public sealed class EditMessageController : ControllerBase
    {
        private readonly IEditMessageCommand _command;

        public EditMessageController(IEditMessageCommand command)
        {
            _command = command;
        }

        [HttpPost("edit")]
        public async Task<IActionResult> Create([FromBody] EditMessageDto dto)
        {
            await _command.Execute(dto);
            return Ok();
        }
    }
}
