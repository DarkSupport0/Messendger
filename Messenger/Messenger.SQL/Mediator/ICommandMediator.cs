using Messenger.SQL.CQRS.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Mediator
{
    public interface ICommandMediator
    {
        public Task Send<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
