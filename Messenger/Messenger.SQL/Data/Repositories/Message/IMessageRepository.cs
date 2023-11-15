using Messenger.SQL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Data.Repositories.Message
{
    public interface IMessageRepository : IRepository
    {
        Task Create(MessageEntity guest);
    }
}
