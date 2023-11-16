using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.User.AddToChat
{
    public interface IAddToChatCommandHandler : ICommandHandler<AddToChatCommand>
    {
    }
}
