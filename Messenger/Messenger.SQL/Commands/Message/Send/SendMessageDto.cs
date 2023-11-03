namespace Messenger.SQL.Commands.Message.Send
{
    public sealed record SendMessageDto
    {
        public SendMessageDto(int userId, int chatId, string message)
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
