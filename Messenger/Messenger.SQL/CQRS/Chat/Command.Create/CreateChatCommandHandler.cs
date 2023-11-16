using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;

namespace Messenger.SQL.CQRS.Chat.Create
{
    public sealed class CreateChatCommandHandler : ICreateChatCommandHandler
    {
        private readonly MessengerDbContext _context;

        public CreateChatCommandHandler(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateChatCommand command)
        {
            ChatEntity entity = new(command.Name, command.Type);

            _context.Chats.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
