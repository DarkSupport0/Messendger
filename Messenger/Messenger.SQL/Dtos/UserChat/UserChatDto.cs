using Messenger.SQL.Data.Entities;
using Messenger.SQL.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Dtos.UserChat
{
    public sealed record UserChatDto : IData
    {
        public int UserId { get; }
        public UserDto User { get; }
        //public int ChatId { get; }

        public UserChatDto(int userId, UserDto user/*, int chatId*/)
        {
            UserId = userId;
            User = user;
            //ChatId = chatId;
        }
    }
}
