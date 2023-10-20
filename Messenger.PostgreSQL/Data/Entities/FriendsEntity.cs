namespace Messenger.PostgreSQL.Data.Entities;

public sealed class FriendsEntity
{
    public int ID { get; set; }
    public int UserID { get; set; }
    public int FriendID { get; set; } 
    
    public UserEntity User { get; set; }
    public UserEntity Friend { get; set; }
}

