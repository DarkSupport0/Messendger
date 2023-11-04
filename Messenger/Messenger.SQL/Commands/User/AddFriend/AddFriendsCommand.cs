using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;

namespace Messenger.SQL.Commands.User.AddFriend
{
    public sealed class AddFriendsCommand : IAddFriendsCommand
    {
        private readonly MessengerDbContext _context;

        public AddFriendsCommand(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Execute(AddFriendsDto data)
        {
            FriendsEntity f1 = new(data.FirstUserId, data.SecondUserId);
            FriendsEntity f2 = new(data.SecondUserId, data.FirstUserId);

            _context.Friends.Add(f1);
            _context.Friends.Add(f2);

            await _context.SaveChangesAsync();
        }
    }
}
