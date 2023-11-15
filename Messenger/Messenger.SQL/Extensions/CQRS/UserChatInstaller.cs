using Messenger.SQL.CQRS.Chat.Create;
using Messenger.SQL.CQRS.Core.Commands;
using Messenger.SQL.CQRS.User.AddToChat;
using Messenger.SQL.CQRS.User.Create;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
