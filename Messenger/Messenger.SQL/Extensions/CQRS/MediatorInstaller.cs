using Messenger.SQL.CQRS.User.AddFriend;
using Messenger.SQL.Mediator;
using Microsoft.Extensions.DependencyInjection;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class MediatorInstaller
    {
        public static IServiceCollection AddMediatorCommands(this IServiceCollection services)
        {
            services
                .AddScoped<IMediator, Mediator.Mediator>();

            return services;
        }
    }
}