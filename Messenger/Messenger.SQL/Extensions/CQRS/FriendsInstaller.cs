using Messenger.SQL.CQRS.User.AddFriend;
using Microsoft.Extensions.DependencyInjection;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class FriendsInstaller
    {
        public static IServiceCollection AddFriendsCommands(this IServiceCollection services)
        {
            services
            .AddScoped<IAddFriendsCommandHandler, AddFriendsCommandHandler>();

            return services;
        }
    }
}
