using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Dtos.Message
{
    public sealed record ChatMessageDto : IData
    {
        public string Message { get; }
        public int SenderId { get; }

        public ChatMessageDto(string message, int sender)
        {
            Message = message;
            SenderId = sender;
        }
    }
}
