using Messenger.SQL.CQRS.User.Query.FindUser;
using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;
using Messenger.SQL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.CQRS.Chat.Query.ChatInfo
{
    public sealed class ChatInfoQueryHandler : IChatInfoQueryHandler
    {
        private readonly MessengerDbContext _context;

        public ChatInfoQueryHandler(MessengerDbContext context)
        {
            _context = context;
        }

        public async Task<ChatInfoDto?> Handle(ChatInfoQuery query)
        {
            ChatEntity? entity = await _context.Chats.Where(s => s.Id == query.Id).FirstOrDefaultAsync();
            ChatInfoDto? dto = null;
            if (entity != null) 
            {
                var messages = await _context.Messages.Where(m => m.ChatId == entity.Id).ToListAsync();
                List<ChatMessageDto> Messages = new();
                foreach (var message in messages)
                {
                    Messages.Add(new ChatMessageDto(message.Message, message.SenderId));
                }

                var users = await _context.UserChat.Where(m => m.ChatId == entity.Id).ToListAsync();
                List<UserChatDto> Users = new();
                for (var i = 0; i < users.Count; i++)
                {
                    var user = await _context.Users.Where(m => m.Id == users[i].UserId).FirstOrDefaultAsync();
                    Users.Add(new UserChatDto(users[i].UserId, new UserDto(user.Id, user.Username, user.Firstname, user.Lastname)));
                }
                    
                
                dto = new(entity.Name, entity.Type, Messages, Users); 
            }
            return dto;
        }
    }
}
