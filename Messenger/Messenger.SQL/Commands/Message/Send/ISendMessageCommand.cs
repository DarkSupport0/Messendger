using Messenger.SQL.Commands.Core;

namespace Messenger.SQL.Commands.Message.Send
{
    public interface ISendMessageCommand : INoResponseAsyncCommand<SendMessageDto>
    {

    }
}
