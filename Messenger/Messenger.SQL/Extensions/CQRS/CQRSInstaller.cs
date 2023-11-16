using Microsoft.Extensions.DependencyInjection;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class CQRSInstaller
    {
        public static IServiceCollection AddCQRS(this IServiceCollection services)
        {
            services
                .AddBanCommands()
                .AddChatCommands()
                .AddFriendsCommands()
                .AddMessageCommands()
                .AddUserChatCommands()
                .AddUserCommands()
                .AddUserQueries();

            return services;
        }
    }
}
