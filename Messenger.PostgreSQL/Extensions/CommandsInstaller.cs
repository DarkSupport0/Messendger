using Messenger.PostgreSQL.Commands.Chat.Create;
using Microsoft.Extensions.DependencyInjection;
using Messenger.PostgreSQL.Commands.User.Create;

namespace WishList.PostgreSQL.Extensions;

public static class CommandsInstaller
{
    public static IServiceCollection AddUserCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateUserCommand, CreateUserCommand>();

        return services;
    }

    public static IServiceCollection AddHolidayCommands(this IServiceCollection services)
    {
        services.AddScoped<ICreateChatCommand, CreateChatCommand>();
        return services;
    }

    public static IServiceCollection AddPresentCommands(this IServiceCollection services)
    {
        return services;
    }
}