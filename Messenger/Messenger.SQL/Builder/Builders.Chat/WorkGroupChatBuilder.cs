using Messenger.SQL.Builder.Builders.Chat.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Builder.Builders.Chat
{
    public class WorkGroupChatBuilder : ChatBuilderByType
    {
        public override void SetName(string chatName)
        {
            ChatProduct.Name = chatName;
        }
        public override void SetType()
        {
            ChatProduct.Type = "Work group";
        }
    }
}
