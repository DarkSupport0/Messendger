using Messenger.SQL.Data.Entities;
using Messenger.SQL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.FactoryMethod.Parts
{
    public sealed class UsersChat
    {
        private readonly ChatInfoDto Chat;
        private readonly List<UserDto> Users;
        public UsersChat(ChatInfoDto chat)
        {
            Chat = chat;
            for (int i = 0; i < Chat.UserChatEntities.Count; i++)
            {
                Users[i] = Chat.UserChatEntities[i].User;
            }
        }
        public override string ToString()
        {
            string part = "";
            part += "Користувачi:\n";
            part += "Iм'я|Прiзвище (нікнейм)\n";
            for (int i = 0;i < Users.Count;i++)
            {
                part += $"{Users[i].Firstname} {Users[i].Lastname} ({Users[i].Username})\n";
            }
            return part;
        }
    }
}
