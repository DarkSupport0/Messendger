﻿using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;

namespace Messenger.SQL.CQRS.User.AddToChat
{
    public sealed class AddToChatCommandHandler : IAddToChatCommandHandler
    {
        private readonly MessengerDbContext _context;

        public AddToChatCommandHandler(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task Handle(AddToChatCommand command)
        {
            UserChatEntity entity = new(command.UserId, command.ChatId, command.IsAdmin);

            _context.UserChat.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
