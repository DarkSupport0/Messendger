using Messenger.SQL.CQRS.Core.Commands;
using Messenger.SQL.CQRS.Core.Queries;
using Messenger.SQL.CQRS.User.Create;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class UserInstaller
    {
        public static IServiceCollection AddUserCommands(this IServiceCollection services)
        {
            services
            .AddScoped<ICreateUserCommandHandler, CreateUserCommandHandler>();

            return services;
        }
    }
}
