using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;
using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.Message.Send
{
    
    public sealed record SendMessageCommand : ICommand
    {
        public SendMessageCommand(int userId, int chatId, string message)
        {
            UserId = userId;
            ChatId = chatId;
            Message = message;
        }

        public int UserId { get; }
        public int ChatId { get; }
        public string Message { get; }
    }
}
