using Messenger.SQL.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Messenger.SQL.Data.Configurations
{
    public sealed class BlackListEntityConfiguration : IEntityTypeConfiguration<BlackListEntity>
    {
        public void Configure(EntityTypeBuilder<BlackListEntity> builder)
        {
            builder.ToTable("BlackLists");
            builder.HasKey(x => x.Id);
        }
    }
}
