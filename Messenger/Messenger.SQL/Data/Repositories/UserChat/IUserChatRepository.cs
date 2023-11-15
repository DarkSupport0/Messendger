using Messenger.SQL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Data.Repositories.UserChat
{
    public interface IUserChatRepository : IRepository
    {
        Task Create(UserChatEntity guest);
    }
}
