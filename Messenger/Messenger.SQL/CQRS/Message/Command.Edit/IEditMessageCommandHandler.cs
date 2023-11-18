using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.Message.Edit
{
    public interface IEditMessageCommandHandler : ICommandHandler<EditMessageCommand>
    {

    }
}
