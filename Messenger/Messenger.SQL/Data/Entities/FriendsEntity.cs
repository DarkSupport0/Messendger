namespace Messenger.SQL.Data.Entities
{
    public class FriendsEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }

        public int FriendId { get; set; }
        public FriendsEntity(int userId, int friendId)
        {
            UserId = userId;
            FriendId = friendId;
        }
    }
}
