using Messenger.SQL.Builder.Builders.Chat.Base;
using Messenger.SQL.Builder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Builder.Directors.Chat
{
    public interface IChatDirector : IDirector
    {
        public void ChangeBuilder(IChatBuilderByType builder);
        public IProduct Make(string name);
    }
}
