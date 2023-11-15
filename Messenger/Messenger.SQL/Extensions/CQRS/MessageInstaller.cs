using Messenger.SQL.CQRS.Core.Commands;
using Messenger.SQL.CQRS.Message.Edit;
using Messenger.SQL.CQRS.Message.Send;
using Messenger.SQL.CQRS.User.Create;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Extensions.CQRS
{
    public static class MessageInstaller
    {
        public static IServiceCollection AddMessageCommands(this IServiceCollection services)
        {
            services
            .AddScoped<IEditMessageCommandHandler, EditMessageCommandHandler>()
            .AddScoped<ISendMessageCommandHandler, SendMessageCommandHandler>();

            return services;
        }
    }
}
