using Messenger.SQL.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.Data.Configurations
{
    public sealed class ChatEntityConfiguration : IEntityTypeConfiguration<ChatEntity>
    {
        public void Configure(EntityTypeBuilder<ChatEntity> builder)
        {
            builder.ToTable("Chats");
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.MessageEntities)
                .WithOne(y => y.Chat)
                .HasForeignKey(y => y.ChatId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.UserChatEntities)
                .WithOne(y => y.Chat)
                .HasForeignKey(y => y.ChatId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
