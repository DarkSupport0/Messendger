using Messenger.SQL.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.Data.Configurations
{
    public sealed class UserChatEntityConfiguration : IEntityTypeConfiguration<UserChatEntity>
    {
        public void Configure(EntityTypeBuilder<UserChatEntity> builder)
        {
            builder.ToTable("UserChat");
            builder.HasKey(x => x.Id);
        }
    }
}
