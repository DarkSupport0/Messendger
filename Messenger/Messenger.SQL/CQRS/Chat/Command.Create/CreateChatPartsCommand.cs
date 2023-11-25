using Messenger.SQL.CQRS.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.CQRS.Chat.Command.Create
{
    public class CreateChatPartsCommand : ICommand
    {
        public CreateChatPartsCommand(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
