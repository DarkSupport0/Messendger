using Messenger.SQL.CQRS.Core.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.CQRS.Chat.Query.ChatInfo
{
    public sealed record ChatInfoQuery : IQuery
    {
        public int Id { get; }

        public ChatInfoQuery(int id)
        {
            Id = id;
        }
    }
}
