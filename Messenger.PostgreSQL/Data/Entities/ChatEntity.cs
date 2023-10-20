namespace Messenger.PostgreSQL.Data.Entities;

public sealed class ChatEntity
{
    public int ID { get; set; }
    public int UserID { get; set; }
    public int SpeakerID { get; set; }
    
    public UserEntity User { get; set; }
}

