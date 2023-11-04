using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;

namespace Messenger.SQL.Commands.Message.Send
{
    public sealed class SendMessageCommand : ISendMessageCommand
    {
        private readonly MessengerDbContext _context;

        public SendMessageCommand(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Execute(SendMessageDto data)
        {
            MessageEntity entity = new(data.Message, data.UserId, data.UserId);

            _context.Messages.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
