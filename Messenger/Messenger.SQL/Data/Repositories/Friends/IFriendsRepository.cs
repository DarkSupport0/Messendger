using Messenger.SQL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Data.Repositories.Friends
{
    public interface IFriendsRepository : IRepository
    {
        Task Create(FriendsEntity guest);
    }
}
