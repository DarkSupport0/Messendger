using Messenger.SQL.CQRS.Core.Queries;

namespace Messenger.SQL.CQRS.User.Query.FindUserById
{
    public sealed record FindUserQueryById : IQuery
    {
        public int Id { get; }

        public FindUserQueryById(int id)
        {
            Id = id;
        }
    }
}
