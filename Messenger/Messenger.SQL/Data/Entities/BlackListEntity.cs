namespace Messenger.SQL.Data.Entities
{
    public class BlackListEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }

        public int BannedId { get; set; }
        public BlackListEntity(int userId, int bannedId)
        {
            UserId = userId;
            BannedId = bannedId;
        }
    }
}
