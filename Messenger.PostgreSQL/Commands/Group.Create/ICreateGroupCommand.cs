using Messenger.PostgreSQL.Commands.Core;
using Messenger.PostgreSQL.Commands.User.Create;

namespace Messenger.PostgreSQL.Commands.Groop.Create;

public interface ICreateGroupCommand:INoResponseAsyncCommand<CreateGroupDto>
{
    
}