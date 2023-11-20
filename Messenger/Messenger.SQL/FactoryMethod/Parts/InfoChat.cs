using Messenger.SQL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.FactoryMethod.Parts
{
    public sealed class InfoChat
    {
        private readonly ChatInfoDto Chat;
        public InfoChat(ChatInfoDto chat)
        {
            Chat = chat;
        }
        public override string ToString() 
        {
            string part = "";
            part += $"Назва чату: {Chat.Name}\n";
            part += $"Тип чату: {Chat.Type}\n";
            return part;
        }
    }
}
