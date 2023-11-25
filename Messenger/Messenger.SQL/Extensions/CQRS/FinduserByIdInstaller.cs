using Messenger.SQL.CQRS.Chat.Create;
using Messenger.SQL.CQRS.Core.Queries;
using Messenger.SQL.CQRS.User.Query.FindUser;
using Messenger.SQL.CQRS.User.Query.FindUserById;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class finduserByIdinstaller
    {
        public static IServiceCollection AddFindUserIdCommands(this IServiceCollection services)
        {
            services
            .AddScoped<IFindUserByIdQueryHandler, FindUserQueryByIdHandler>();

            return services;
        }
    }
}
