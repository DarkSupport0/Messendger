using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.Commands.Message.Edit
{
    public sealed class EditMessageCommand : IEditMessageCommand
    {
        private readonly MessengerDbContext _context;

        public EditMessageCommand(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Execute(EditMessageDto data)
        {
            MessageEntity? entity = await _context.Messages.Where(x => x.Id == data.MessageId).FirstOrDefaultAsync();

            if (entity != null)
            {
                entity.Message = data.NewText;
                await _context.SaveChangesAsync();
            }
        }
    }
}
