using Messenger.SQL.CQRS.User.Query.FindUser;
using Messenger.SQL.Data;
using Messenger.SQL.Data.Entities;
using Messenger.SQL.Dtos.User;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.CQRS.User.Query.FindUserById
{
    public sealed class FindUserQueryByIdHandler : IFindUserByIdQueryHandler
    {
        private readonly MessengerDbContext _context;

        public FindUserQueryByIdHandler(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task<FindUserDto?> Handle(FindUserQueryById query)
        {
            UserEntity? entity = await _context.Users.Where(s => s.Id == query.Id).FirstOrDefaultAsync();
            FindUserDto? dto = null;
            if (entity != null) { dto = new(entity.Username, entity.Firstname, entity.Lastname, entity.Birthday, entity.Email, entity.Phone, entity.Country); }

            return dto;
        }
    }
}
