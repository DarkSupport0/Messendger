using Messenger.PostgreSQL.Commands.Core;

namespace Messenger.PostgreSQL.Commands.User.Create;

public interface ICreateUserCommand
{
    Task Execute(CreateUserDto dto);
}