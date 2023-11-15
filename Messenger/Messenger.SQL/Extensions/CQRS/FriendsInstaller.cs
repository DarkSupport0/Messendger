using Messenger.SQL.CQRS.Core.Commands;
using Messenger.SQL.CQRS.User.AddFriend;
using Messenger.SQL.CQRS.User.Create;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
