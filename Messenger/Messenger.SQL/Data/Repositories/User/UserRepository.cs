using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data.Repositories.BlackList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Data.Repositories.User
{
    public sealed class UserRepository : IUserRepository
    {
        private readonly MessengerDbContext _context;

        public UserRepository(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Create(UserEntity guest)
        {
            await _context.Users.AddAsync(guest);
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
