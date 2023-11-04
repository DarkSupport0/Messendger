namespace Messenger.SQL.Data.Entities
{
    public class ChatEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<MessageEntity> MessageEntities { get; set; }
        public virtual ICollection<UserChatEntity> UserChatEntities { get; set; }
        public ChatEntity(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
