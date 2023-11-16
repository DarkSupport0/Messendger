using Messenger.SQL.CQRS.User.BlockUser;
using Microsoft.Extensions.DependencyInjection;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class BlackListInstaller
    {
        public static IServiceCollection AddBanCommands(this IServiceCollection services)
        {
            services
            .AddScoped<IBlockUserCommandHandler, BlockUserCommandHandler>();

            return services;
        }
    }
}
