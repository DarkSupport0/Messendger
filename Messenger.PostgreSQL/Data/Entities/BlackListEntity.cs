namespace Messenger.PostgreSQL.Data.Entities;

public sealed class BlackListEntity
{
    public int ID { get; set; }
    public int UserID { get; set; }
    public int BanID { get; set; }
        
    public UserEntity User { get; set; }
}

