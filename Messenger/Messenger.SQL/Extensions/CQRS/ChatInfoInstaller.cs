using Messenger.SQL.CQRS.Chat.Query.ChatInfo;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class ChatInfoInstaller
    {
        public static IServiceCollection AddChatInfoCommands(this IServiceCollection services)
        {
            services
            .AddScoped<IChatInfoQueryHandler, ChatInfoQueryHandler>();

            return services;
        }
    }
}
