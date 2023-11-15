using Messenger.SQL.CQRS.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Messenger.SQL.CQRS.Message.Send
{
    public interface ISendMessageCommandHandler : ICommandHandler<SendMessageCommand>
    {
    }
}
