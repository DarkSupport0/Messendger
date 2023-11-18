using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;

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
