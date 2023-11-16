using Messenger.SQL.CQRS.Core.Queries;

namespace Messenger.SQL.CQRS.User.Query.FindUser
{
    public sealed record FindUserQuery : IQuery
    {
        public string Username { get; }

        public FindUserQuery(string username) 
        {
            Username = username;
        }
    }
}
