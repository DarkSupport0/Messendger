using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.User.Create
{
    public interface ICreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
    }
}
