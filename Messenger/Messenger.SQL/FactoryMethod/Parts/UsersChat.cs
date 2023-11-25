using Messenger.SQL.Data.Entities;
using Messenger.SQL.Dtos.Chat;
using Messenger.SQL.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.FactoryMethod.Parts
{
    public sealed class UsersChat : IFileParts
    {
        private readonly ChatInfoDto Chat;
        private readonly List<UserDto> Users;
        public UsersChat(ChatInfoDto chat)
        {
            Chat = chat;
        }
        public string ConvertToString()
        {
            string part = "";
            part += "Користувачi:\n";
            part += "Iм'я|Прiзвище (нікнейм)\n\n";
            foreach (var user in Chat.UserChatEntities)
            {
                part += $"{user.User.Firstname} {user.User.Lastname} ({user.User.Username})\n";
            }
            part += "---------------------------\n\n";
            return part;
        }
    }
}
