﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infrastructure.Persistence.Configurations.Users
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(s => s.FullName).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(s => s.Email).IsRequired().HasMaxLength((int)MaxLengthSize.EmailAddress);
            builder.HasIndex(s => s.Email).IsUnique();
        }
    }
}
