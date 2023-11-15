using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;
using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.User.AddFriend
{
    
    public sealed record AddFriendsCommand : ICommand 
    {
        public AddFriendsCommand(int firstUserId, int secondUserId)
        {
            FirstUserId = firstUserId;
            SecondUserId = secondUserId;
        }

        public int FirstUserId { get; }
        public int SecondUserId { get; }
    }
}
