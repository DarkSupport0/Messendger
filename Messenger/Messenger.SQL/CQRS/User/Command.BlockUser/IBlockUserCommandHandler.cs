using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.User.BlockUser
{
    public interface IBlockUserCommandHandler : ICommandHandler<BlockUserCommand>
    {
    }
}
