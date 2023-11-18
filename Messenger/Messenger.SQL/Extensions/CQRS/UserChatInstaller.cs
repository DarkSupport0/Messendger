using Messenger.SQL.CQRS.User.AddToChat;
using Microsoft.Extensions.DependencyInjection;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class UserChatInstaller
    {
        public static IServiceCollection AddUserChatCommands(this IServiceCollection services)
        {
            services
            .AddScoped<IAddToChatCommandHandler, AddToChatCommandHandler>();

            return services;
        }
    }
}
