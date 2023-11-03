using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;

namespace Messenger.SQL.Commands.User.BlockUser
{
    public sealed class BlockUserCommand : IBlockUserCommand
    {
        private readonly MessengerDbContext _context;

        public BlockUserCommand(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Execute(BlockUserDto data)
        {
            BlackListEntity entity = new(data.UserId, data.BannedId);

            _context.BlackList.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
