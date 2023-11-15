using Messenger.SQL.CQRS.Chat.Create;
using Messenger.SQL.CQRS.User.AddFriend;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class ChatInstaller
    {
        public static IServiceCollection AddChatCommands(this IServiceCollection services)
        {
            services
            .AddScoped<ICreateChatCommandHandler, CreateChatCommandHandler>();

            return services;
        }
    }
}
