using Messenger.SQL.CQRS.Chat.Create;
using Messenger.SQL.CQRS.User.BlockUser;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
