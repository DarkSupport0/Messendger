using Messenger.SQL.Commands.Core;

namespace Messenger.SQL.Commands.User.Create
{
    public interface ICreateUserCommand : INoResponseAsyncCommand<CreateUserDto>
    {

    }
}
