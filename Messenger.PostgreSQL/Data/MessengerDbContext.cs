using System.Reflection;
using Messenger.PostgreSQL.Data.Entities;
using Microsoft.EntityFrameworkCore;
namespace Messenger.PostgreSQL.Data;
public sealed class MessengerDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; init; }
    public DbSet<FriendsEntity> Friends { get; init; }
    public DbSet<ChatEntity> Chat { get; init; }
    public DbSet<BlackListEntity> BlackList { get; init; }

    public MessengerDbContext(DbContextOptions<MessengerDbContext> options): base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}