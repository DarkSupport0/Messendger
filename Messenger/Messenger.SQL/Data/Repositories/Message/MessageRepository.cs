using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data.Repositories.BlackList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Data.Repositories.Message
{
    public sealed class MessageRepository : IMessageRepository
    {
        private readonly MessengerDbContext _context;

        public MessageRepository(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Create(MessageEntity guest)
        {
            await _context.Messages.AddAsync(guest);
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
