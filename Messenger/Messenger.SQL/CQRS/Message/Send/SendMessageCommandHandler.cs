using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.CQRS.Message.Send
{
    public sealed class SendMessageCommandHandler : ISendMessageCommandHandler
    {
        private readonly MessengerDbContext _context;

        public SendMessageCommandHandler(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Handle(SendMessageCommand command)
        {
            MessageEntity entity = new(command.Message, command.UserId, command.UserId);

            _context.Messages.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
