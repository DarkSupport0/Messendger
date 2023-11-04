using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;

namespace Messenger.SQL.Commands.User.AddToChat
{
    public sealed class AddToChatCommand : IAddToChatCommand
    {
        private readonly MessengerDbContext _context;

        public AddToChatCommand(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Execute(AddToChatDto data)
        {
            UserChatEntity entity = new(data.UserId, data.ChatId, data.IsAdmin);

            _context.UserChat.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
