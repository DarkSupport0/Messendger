using Messenger.SQL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Messenger.SQL.Data
{
    public sealed class MessengerDbContext : DbContext
    {
        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<BlackListEntity> BlackList { get; set; }
        public DbSet<FriendsEntity> Friends { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet<UserChatEntity> UserChat { get; set; }

        public MessengerDbContext(DbContextOptions<MessengerDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
