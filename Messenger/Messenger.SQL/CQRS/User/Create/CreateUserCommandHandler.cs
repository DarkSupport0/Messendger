using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.CQRS.User.Create
{
    public sealed class CreateUserCommandHandler : ICreateUserCommandHandler
    {
        private readonly MessengerDbContext _context;

        public CreateUserCommandHandler(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateUserCommand command)
        {
            UserEntity entity = new(command.Username, command.Firstname, command.Lastname, command.Birthday, command.Email, command.Phone, command.Country);

            _context.Users.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
