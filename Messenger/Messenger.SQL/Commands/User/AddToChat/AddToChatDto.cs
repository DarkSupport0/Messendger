namespace Messenger.SQL.Commands.User.AddToChat
{
    public sealed record AddToChatDto
    {
        public AddToChatDto(int userId, int chatId, bool isAdmin)
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
