using Messenger.SQL.Commands.Chat.Create;
using Messenger.SQL.Commands.Message.Edit;
using Messenger.SQL.Commands.Message.Send;
using Messenger.SQL.Commands.User.AddFriend;
using Messenger.SQL.Commands.User.AddToChat;
using Messenger.SQL.Commands.User.BlockUser;
using Messenger.SQL.Commands.User.Create;
using Microsoft.Extensions.DependencyInjection;

namespace Messenger.SQL.Extensions
{
    public static class CommandsInstaller
    {
        public static IServiceCollection AddChatCommands(this IServiceCollection services)
        {
            services.AddScoped<ICreateChatCommand, CreateChatCommand>();

            return services;
        }
        public static IServiceCollection AddMessageCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ISendMessageCommand, SendMessageCommand>()
                .AddScoped<IEditMessageCommand, EditMessageCommand>();

            return services;
        }
        public static IServiceCollection AddUserCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateUserCommand, CreateUserCommand>()
                .AddScoped<IAddToChatCommand, AddToChatCommand>()
                .AddScoped<IBlockUserCommand, BlockUserCommand>()
                .AddScoped<IAddFriendsCommand, AddFriendsCommand>();

            return services;
        }
    }
}
