using Messenger.SQL.Dtos.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.FactoryMethod.Parts
{
    public sealed class InfoChat : IFileParts
    {
        private readonly ChatInfoDto Chat;
        public InfoChat(ChatInfoDto chat)
        {
            Chat = chat;
        }
        public string ConvertToString() 
        {
            string part = "";
            part += $"Назва чату: {Chat.Name}\n";
            part += $"Тип чату: {Chat.Type}\n";
            part += "---------------------------\n\n";
            return part;
        }
    }
}
