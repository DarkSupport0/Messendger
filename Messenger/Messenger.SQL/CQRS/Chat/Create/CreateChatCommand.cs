using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;
using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.Chat.Create
{
    
    public sealed record CreateChatCommand : ICommand
    {
        public CreateChatCommand(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public string Type { get; }
    }
}
