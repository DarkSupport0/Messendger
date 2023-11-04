namespace Messenger.SQL.Data.Entities
{
    public class MessageEntity
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime SendAt { get; set; } = DateTime.Now;

        public int SenderId { get; set; }
        public virtual UserEntity Sender { get; set; }

        public int ChatId { get; set; }
        public virtual ChatEntity Chat { get; set; }
        public MessageEntity(string message, int senderId, int chatId)
        {
            Message = message;
            SenderId = senderId;
            ChatId = chatId;
        }
    }
}
