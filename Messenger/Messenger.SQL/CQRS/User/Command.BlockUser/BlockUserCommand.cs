using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.User.BlockUser
{
    
    public sealed record BlockUserCommand : ICommand
    {
        public BlockUserCommand(int userId, int bannedId)
        {
            UserId = userId;
            BannedId = bannedId;
        }

        public int UserId { get; }
        public int BannedId { get; }
    }
}
