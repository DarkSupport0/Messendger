using Messenger.SQL.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.Data.Configurations
{
    public sealed class MessageEntityConfiguration : IEntityTypeConfiguration<MessageEntity>
    {
        public void Configure(EntityTypeBuilder<MessageEntity> builder)
        {
            builder.ToTable("Messages");
            builder.HasKey(x => x.Id);
        }
    }
}
