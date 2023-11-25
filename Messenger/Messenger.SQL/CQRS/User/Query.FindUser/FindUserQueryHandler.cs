using Messenger.SQL.Data;
using Messenger.SQL.Data.Entities;
using Messenger.SQL.Dtos.User;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.CQRS.User.Query.FindUser
{
    public sealed class FindUserQueryHandler : IFindUserQueryHandler
    {
        private readonly MessengerDbContext _context;

        public FindUserQueryHandler(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task<FindUserDto?> Handle(FindUserQuery query)
        {
            UserEntity? entity = await _context.Users.Where(s => s.Username == query.Username).FirstOrDefaultAsync();
            FindUserDto? dto = null;
            if (entity != null) { dto = new(entity.Username, entity.Firstname, entity.Lastname, entity.Birthday, entity.Email, entity.Phone, entity.Country); }

            return dto;
        }
    }
}
