using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.Chat.Create
{
    public interface ICreateChatCommandHandler : ICommandHandler<CreateChatCommand>
    {
    }
}
