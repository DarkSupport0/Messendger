using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class CQRSInstaller
    {
        public static IServiceCollection AddSQRS(this IServiceCollection services)
        {
            services
                .AddBanCommands()
                .AddChatCommands()
                .AddFriendsCommands()
                .AddMessageCommands()
                .AddUserChatCommands()
                .AddUserCommands();

            return services;
        }
    }
}
