using Messenger.PostgreSQL.Commands.Chat.Create;

namespace Messenger.PostgreSQL.Commands.User.Create;

public class CreateUserCommand : ICreateUserCommand
{
    public Task Execute(CreateUserDto dto)
    {
        throw new NotImplementedException();
    }
}