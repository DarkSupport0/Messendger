using Messenger.SQL.CQRS.Core.Queries;
using Messenger.SQL.CQRS.User.Query.FindUserById;
using Messenger.SQL.Dtos.User;

namespace Messenger.SQL.CQRS.User.Query.FindUserById
{
    public interface IFindUserByIdQueryHandler : IQueryHandler<FindUserQueryById, FindUserDto?>
    {
    }
}
