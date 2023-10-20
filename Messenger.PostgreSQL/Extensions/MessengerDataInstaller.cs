using System.Reflection;
using Messenger.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Messenger.PostgreSQL.Extensions;

public static class MessengerDataInstaller
{
    public static IServiceCollection AddMessendgerData(this IServiceCollection services, string connectionString)
    {
        services.AddDbContextPool<MessengerDbContext>(options => 
            options
                .UseNpgsql(connectionString, builder => builder.MigrationsAssembly("Messenger.PostgreSQL"))
        );

        return services;
    }
}