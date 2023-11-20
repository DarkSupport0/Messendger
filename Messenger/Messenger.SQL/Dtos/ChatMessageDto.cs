using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Dtos
{
    public sealed record ChatMessageDto
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
