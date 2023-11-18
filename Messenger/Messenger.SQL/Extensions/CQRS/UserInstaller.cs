using Messenger.SQL.CQRS.User.Create;
using Messenger.SQL.CQRS.User.Query.FindUser;
using Microsoft.Extensions.DependencyInjection;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class UserInstaller
    {
        public static IServiceCollection AddUserCommands(this IServiceCollection services)
        {
            services
            .AddScoped<ICreateUserCommandHandler, CreateUserCommandHandler>();

            return services;
        }
        public static IServiceCollection AddUserQueries(this IServiceCollection services)
        {
            services
            .AddScoped<IFindUserQueryHandler, FindUserQueryHandler>();

            return services;
        }
    }
}
