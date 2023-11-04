using Messenger.SQL.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.Extensions
{
    public static class MessengerDataInstaller
    {
        public static IServiceCollection AddMessengerData(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<MessengerDbContext>(options =>
                options.UseSqlServer(connectionString, builder => builder.MigrationsAssembly("Messenger.SQL"))
            );

            return services;
        }
    }
}
