using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.CQRS.User.BlockUser
{
    public sealed class BlockUserCommandHandler : IBlockUserCommandHandler
    {
        private readonly MessengerDbContext _context;

        public BlockUserCommandHandler(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Handle(BlockUserCommand command)
        {
            BlackListEntity entity = new(command.UserId, command.BannedId);

            _context.BlackList.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
