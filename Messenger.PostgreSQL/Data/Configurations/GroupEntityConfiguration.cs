using Messenger.PostgreSQL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Messenger.PostgreSQL.Data.Configurations;

public sealed partial class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<GroupEntity> builder)
    {
        builder.HasKey(e => e.ID);
        builder.HasMany(e => e.Users)
            .WithMany(c => c.Groups)
            .UsingEntity(ing => ing.ToTable(""));
    }
}