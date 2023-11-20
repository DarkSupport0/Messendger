using Messenger.SQL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Dtos
{
    public sealed record UserChatDto
    {
        public int UserId { get; }
        public UserDto User { get; }

        public UserChatDto(int userId, UserDto user)
        {
            UserId = userId;
            User = user;
        }
    }
}
