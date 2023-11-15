using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data.Repositories.BlackList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Data.Repositories.Friends
{
    public sealed class FriendsRepository : IFriendsRepository
    {
        private readonly MessengerDbContext _context;

        public FriendsRepository(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Create(FriendsEntity guest)
        {
            await _context.Friends.AddAsync(guest);
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
