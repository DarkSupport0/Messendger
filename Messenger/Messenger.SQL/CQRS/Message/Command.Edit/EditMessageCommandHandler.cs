using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;
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
