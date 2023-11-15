using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.CQRS.Message.Edit
{
    public sealed class EditMessageCommandHandler : IEditMessageCommandHandler
    {
        private readonly MessengerDbContext _context;

        public EditMessageCommandHandler(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Handle(EditMessageCommand command)
        {
            MessageEntity? entity = await _context.Messages.Where(x => x.Id == command.MessageId).FirstOrDefaultAsync();

            if (entity != null)
            {
                entity.Message = command.NewText;
                await _context.SaveChangesAsync();
            }
        }

    }
}
