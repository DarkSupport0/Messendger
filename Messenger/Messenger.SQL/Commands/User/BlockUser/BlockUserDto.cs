namespace Messenger.SQL.Commands.User.BlockUser
{
    public sealed record BlockUserDto
    {
        public BlockUserDto(int userId, int bannedId)
        {
            UserId = userId;
            BannedId = bannedId;
        }

        public int UserId { get; }
        public int BannedId { get; }
    }
}
