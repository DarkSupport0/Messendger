using Messenger.SQL.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.Data.Configurations
{
    public sealed class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.FriendsEntities)
                .WithOne(y => y.User)
                .HasForeignKey(y => y.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.UserChatEntities)
                .WithOne(y => y.User)
                .HasForeignKey(y => y.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.BlackListEntities)
                .WithOne(y => y.User)
                .HasForeignKey(y => y.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.MessageEntities)
                .WithOne(y => y.Sender)
                .HasForeignKey(y => y.SenderId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
