using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.User.AddToChat
{
    
    public sealed record AddToChatCommand : ICommand
    {
        public AddToChatCommand(int userId, int chatId, bool isAdmin)
        {
            UserId = userId;
            ChatId = chatId;
            IsAdmin = isAdmin;
        }

        public int UserId { get; }
        public int ChatId { get; }
        public bool IsAdmin { get; }
    }
}
