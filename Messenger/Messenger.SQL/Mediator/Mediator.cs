using Messenger.SQL.CQRS.Core.Commands;
using Messenger.SQL.CQRS.Core.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Mediator
{
    public sealed class Mediator : IMediator
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public Mediator(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            await using AsyncServiceScope scope = _serviceScopeFactory.CreateAsyncScope();
            IServiceProvider provider = scope.ServiceProvider;
            ICommandHandler<TCommand> handler = provider.GetRequiredService<ICommandHandler<TCommand>>();
            await handler.Handle(command);
        }

        public async Task<TResult> Send<TQuery, TResult>(TQuery query) where TQuery : IQuery
        {
            await using AsyncServiceScope scope = _serviceScopeFactory.CreateAsyncScope();
            IServiceProvider provider = scope.ServiceProvider;
            IQueryHandler<TQuery, TResult> handler = provider.GetRequiredService<IQueryHandler<TQuery, TResult>>();
            return await handler.Handle(query);
        }
    }
}
