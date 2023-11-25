using Messenger.SQL.CQRS.Core.Queries;
using Messenger.SQL.Dtos.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.CQRS.Chat.Query.ChatInfo
{
    public interface IChatInfoQueryHandler : IQueryHandler<ChatInfoQuery, ChatInfoDto?>
    {
    }
}
