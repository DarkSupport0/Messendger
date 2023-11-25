using Messenger.SQL.CQRS.Chat.Query.ChatInfo;
using Messenger.SQL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Chat.ReportWork
{
    [ApiController]
    [Route("chats")]
    [ApiExplorerSettings(GroupName = "chats")]
    public class ChatInfoController : ControllerBase
    {
        private readonly IChatInfoQueryHandler _query;

        public ChatInfoController(IChatInfoQueryHandler query)
        {
            _query = query;
        }

        [HttpPost("find")]
        public async Task<ChatInfoDto?> Find(int Id)
        {
            return await _query.Handle(new ChatInfoQuery(Id));
        }
    }
}
