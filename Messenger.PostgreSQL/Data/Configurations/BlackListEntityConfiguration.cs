﻿using Messenger.PostgreSQL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Messenger.PostgreSQL.Data.Configurations;

public sealed partial class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<BlackListEntity> builder)
    {
        builder.HasKey(e => e.ID);
       
        builder.HasOne(c => c.User)
            .WithMany(u => u.BlackList)
            .HasForeignKey(c => c.UserID);
    }
}