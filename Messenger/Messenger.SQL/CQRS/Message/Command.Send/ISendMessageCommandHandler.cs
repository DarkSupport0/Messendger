using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.Message.Send
{
    public interface ISendMessageCommandHandler : ICommandHandler<SendMessageCommand>
    {
    }
}
