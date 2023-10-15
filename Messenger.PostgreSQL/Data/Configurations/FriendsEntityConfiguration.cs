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
        
    }
    protected Expression<Func<FriendsEntity, object>> Key =>
        member => new {member.UserID, member.FriendID};
}