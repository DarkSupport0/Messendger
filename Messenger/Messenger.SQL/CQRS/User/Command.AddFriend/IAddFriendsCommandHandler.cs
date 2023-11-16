using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.User.AddFriend
{
    public interface IAddFriendsCommandHandler : ICommandHandler<AddFriendsCommand>
    {
    }
}
