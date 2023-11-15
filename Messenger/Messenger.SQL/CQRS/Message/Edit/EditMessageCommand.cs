using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data;
using Microsoft.EntityFrameworkCore;
using Messenger.SQL.CQRS.Core.Commands;

namespace Messenger.SQL.CQRS.Message.Edit
{
    
    public sealed class EditMessageCommand : ICommand
    {
        public EditMessageCommand(int messageId, string newText)
        {
            MessageId = messageId;
            NewText = newText;
        }

        public int MessageId { get; set; }
        public string NewText { get; set; }
    }
}
