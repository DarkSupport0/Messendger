using Messenger.SQL.CQRS.Message.Edit;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Message
{
    [ApiController]
    [Route("massages")]
    [ApiExplorerSettings(GroupName = "massages")]
    public sealed class EditMessageController : ControllerBase
    {
        private readonly IEditMessageCommandHandler _command;

        public EditMessageController(IEditMessageCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("edit")]
        public async Task<IActionResult> Create([FromBody] EditMessageCommand command)
        {
            await _command.Handle(command);
            return Ok();
        }
    }
}
