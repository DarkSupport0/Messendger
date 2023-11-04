using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;

namespace Messenger.SQL.Commands.User.Create
{
    public sealed class CreateUserCommand : ICreateUserCommand
    {
        private readonly MessengerDbContext _context;

        public CreateUserCommand(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Execute(CreateUserDto data)
        {
            UserEntity entity = new(data.Username, data.Firstname, data.Lastname, data.Birthday, data.Email, data.Phone, data.Country);

            _context.Users.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
