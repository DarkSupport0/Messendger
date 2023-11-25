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
    public sealed class MessageChat : IFileParts
    {
        private ChatInfoDto Chat;
        private IEnumerable<UserDto> Username;
        public MessageChat(ChatInfoDto chat)
        {
            Chat = chat;
        }
        public string ConvertToString()
        {
            string part = "";
            part += "Повідомлення чату:\n";
            part += "Нікнейм: повідомлення\n\n";
            for (int i = 0; i < Chat.MessageEntities.Count; i++)
            {
                int Id = Chat.MessageEntities[i].SenderId;
                Username = from user in Chat.UserChatEntities
                           where user.UserId == Id
                           select user.User;
                part += $"{Username.FirstOrDefault().Username}: {Chat.MessageEntities[i].Message}\n";
            }
            return part;
        }

    }
}
