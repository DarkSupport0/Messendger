namespace Messenger.SQL.Data.Entities
{
    public class UserChatEntity
    {       
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }

        public bool IsAdmin { get; set; }

        public int ChatId { get; set; }
        public virtual ChatEntity Chat { get; set; }
        public UserChatEntity(int userId, int chatId, bool isAdmin)
        {
            UserId = userId;
            IsAdmin = isAdmin;
            ChatId = chatId;
        }
    }
}
