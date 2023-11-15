using Messenger.SQL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Data.Repositories.BlackList
{
    public sealed class BlackListRepository : IBlackListRepository
    {
        private readonly MessengerDbContext _context;

        public BlackListRepository(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Create(BlackListEntity guest)
        {
            await _context.BlackList.AddAsync(guest);
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
