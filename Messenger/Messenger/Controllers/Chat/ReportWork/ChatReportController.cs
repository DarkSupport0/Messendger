using Messenger.SQL.CQRS.Chat.Query.ChatInfo;
using Messenger.SQL.Dtos.Chat;
using Messenger.SQL.FactoryMethod.Report;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Chat.ReportWork
{
    [ApiController]
    [Route("chats")]
    [ApiExplorerSettings(GroupName = "chats")]
    public class ChatReportController : ControllerBase
    {
        private readonly IChatInfoQueryHandler _chat;

        public ChatReportController(IChatInfoQueryHandler chat)
        {
            _chat = chat;
        }

        [HttpGet("report")]
        public async Task CreateFile(int id)
        {
            ChatInfoDto? club = await _chat.Handle(new ChatInfoQuery(id));

            if (club == null) return;
            AddParts reportWriter = new();
            reportWriter.RenderFile(club);
            reportWriter.SaveToFile();
        }
    }
}
