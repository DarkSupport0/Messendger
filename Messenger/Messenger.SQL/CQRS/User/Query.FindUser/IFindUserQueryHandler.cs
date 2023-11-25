using Messenger.SQL.CQRS.Core.Queries;
using Messenger.SQL.Dtos.User;

namespace Messenger.SQL.CQRS.User.Query.FindUser
{
    public interface IFindUserQueryHandler : IQueryHandler<FindUserQuery, FindUserDto?>
    {
    }
}
