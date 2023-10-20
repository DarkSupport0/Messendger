using Messenger.PostgreSQL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace Messenger.PostgreSQL.Data.Configurations;

public sealed partial class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<FriendsEntity> builder)
    {
        builder.HasKey(e => e.ID);
        builder.HasOne(c => c.User)
            .WithMany(u => u.Friends)
            .HasForeignKey(c => c.UserID);
        builder.HasOne(c => c.Friend)
            .WithMany(u => u.Friends)
            .HasForeignKey(c => c.FriendID);
    }
}