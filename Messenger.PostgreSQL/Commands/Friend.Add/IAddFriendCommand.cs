using Messenger.PostgreSQL.Commands.Core;
using Messenger.PostgreSQL.Commands.User.Create;

namespace Messenger.PostgreSQL.Commands.Friend.Add;

public interface IAddFriendCommand:INoResponseAsyncCommand<AddFriendDto>
{
    
}