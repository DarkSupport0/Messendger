using Messenger.PostgreSQL.Commands.Core;

namespace Messenger.PostgreSQL.Commands.Chat.Create;

public interface ICreateChatCommand:INoResponseAsyncCommand<CreateChatDto>
{
    
}