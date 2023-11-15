using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data.Repositories.BlackList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Data.Repositories.UserChat
{
    public sealed class UserChatRepository : IUserChatRepository
    {
        private readonly MessengerDbContext _context;

        public UserChatRepository(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Create(UserChatEntity guest)
        {
            await _context.UserChat.AddAsync(guest);
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
