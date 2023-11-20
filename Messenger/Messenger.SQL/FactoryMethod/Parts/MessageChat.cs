using Messenger.SQL.Data.Entities;
using Messenger.SQL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.FactoryMethod.Parts
{
    public sealed class MessageChat
    {
        private ChatInfoDto Chat;
        private List<UserDto> Users;
        private List<ChatMessageDto> Messages;
        private IEnumerable<UserDto> Username;
        public MessageChat(ChatInfoDto chat)
        {
            Chat = chat;
            Messages = Chat.MessageEntities;
            List<UserChatDto> Userchat = Chat.UserChatEntities;
            for (int i = 0; i < Userchat.Count; i++) 
            {
                Users[i] = Userchat[i].User;
            }
        }
        public override string ToString()
        {
            string part = "";
            part += "Повідомлення чату:\n";
            part += "Нікнейм: повідомлення\n";
            for (int i = 0; i < Messages.Count; i++)
            {
                int Id = Messages[i].SenderId;
                Username = from user in Users
                           where user.Id == Id
                           select user;
                part += $"{Username.FirstOrDefault().Username}: {Messages[i].Message}";
            }
            return part;
        }

    }
}
