using Messenger.SQL.Builder.Builders.Chat.Base;
using Messenger.SQL.Builder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Builder.Directors.Chat
{
    public class ChatDirector : IChatDirector
    {
        private IChatBuilderByType Builder { get; set; }

        public ChatDirector(IChatBuilderByType builder)
        {
            Builder = builder;
        }

        public void ChangeBuilder(IChatBuilderByType builder)
        {
            Builder = builder;
        }

        public IProduct Make(string name)
        {
            Builder.Reset();
            Builder.SetName(name);
            Builder.SetType();
            return Builder.GetProduct();
        }
    }
}
