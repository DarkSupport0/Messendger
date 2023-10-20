using Messenger.PostgreSQL.Commands.Core;

namespace Messenger.PostgreSQL.Commands.User.Create;

public interface ICreateUserCommand:INoResponseAsyncCommand<CreateUserDto>
{
    
}