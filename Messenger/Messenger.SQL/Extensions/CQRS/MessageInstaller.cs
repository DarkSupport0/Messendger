using Messenger.SQL.CQRS.Message.Edit;
using Messenger.SQL.CQRS.Message.Send;
using Microsoft.Extensions.DependencyInjection;

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
