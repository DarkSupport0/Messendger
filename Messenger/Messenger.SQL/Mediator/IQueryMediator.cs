using Messenger.SQL.CQRS.Core.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Mediator
{
    public interface IQueryMediator
    {
        public Task<TResult> Send<TQuery, TResult>(TQuery query) where TQuery : IQuery;
    }
}
