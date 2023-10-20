namespace Messenger.PostgreSQL.Data.Entities;

public sealed class UserEntity
{
    public int ID { get; set; }
    public string Username { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime Birthday { get; set; }
    public string Email { get; set; }
    public string Numphone { get; set; }
    public string Country { get; set; }
       
    public List<BlackListEntity> BlackList { get; set; }
    public List<FriendsEntity> Friends { get; set; }
    public ChatEntity Speaker { get; set; }
    public List<GroupEntity> Groups { get; set; }
}

