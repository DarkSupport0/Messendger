using Messenger.SQL.CQRS.Chat.Create;
using Microsoft.Extensions.DependencyInjection;

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
