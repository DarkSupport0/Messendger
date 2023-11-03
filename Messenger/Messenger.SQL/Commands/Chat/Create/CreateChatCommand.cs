using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;

namespace Messenger.SQL.Commands.Chat.Create
{
    public sealed class CreateChatCommand : ICreateChatCommand
    {
        private readonly MessengerDbContext _context;

        public CreateChatCommand(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Execute(CreateChatDto data)
        {
            ChatEntity entity = new(data.Name, data.Type);

            _context.Chats.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
