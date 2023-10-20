using Messenger.PostgreSQL.Commands.Core;

namespace Messenger.PostgreSQL.Commands.BlackList.Add;

public interface IAddBlackListCommand:INoResponseAsyncCommand<AddBlackListDto>
{
    
}