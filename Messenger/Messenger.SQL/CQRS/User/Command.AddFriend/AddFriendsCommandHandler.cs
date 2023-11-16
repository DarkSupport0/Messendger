using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;

namespace Messenger.SQL.CQRS.User.AddFriend
{
    public sealed class AddFriendsCommandHandler : IAddFriendsCommandHandler
    {
        private readonly MessengerDbContext _context;

        public AddFriendsCommandHandler(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Handle(AddFriendsCommand command)
        {
            FriendsEntity f1 = new(command.FirstUserId, command.SecondUserId);
            FriendsEntity f2 = new(command.SecondUserId, command.FirstUserId);

            _context.Friends.Add(f1);
            _context.Friends.Add(f2);

            await _context.SaveChangesAsync();
        }
    }
}
