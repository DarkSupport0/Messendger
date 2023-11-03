using Messenger.SQL.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.Data.Configurations
{
    public sealed class FriendsEntityConfiguration : IEntityTypeConfiguration<FriendsEntity>
    {
        public void Configure(EntityTypeBuilder<FriendsEntity> builder)
        {
            builder.ToTable("Friends");
            builder.HasKey(x => x.Id);
        }
    }
}
