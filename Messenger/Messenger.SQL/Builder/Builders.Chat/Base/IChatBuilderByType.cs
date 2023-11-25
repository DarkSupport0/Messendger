using Messenger.SQL.Builder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Builder.Builders.Chat.Base
{
    public interface IChatBuilderByType : IBuilder
    {
        public void SetName(string clubName);
        public void SetType();
    }
}
