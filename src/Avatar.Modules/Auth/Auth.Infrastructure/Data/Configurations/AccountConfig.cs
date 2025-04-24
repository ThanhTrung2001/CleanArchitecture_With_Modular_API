using Avatar.Modules.Auth.Auth.Domain.Entities;
using Avatar.Modules.Auth.Auth.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar.Modules.Auth.Auth.Infrastructure.Data.Configurations
{
    public class AccountConfig : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .IsRequired();

            builder.Property(x => x.CreatedDate)
                .HasDefaultValueSql("SYSDATETIMEOFFSET()");

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder.Property(x => x.UserName)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Password)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(255);

            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(x => x.Role)
                .HasDefaultValue(EAccountRole.User)
                .IsRequired();

            builder.Property(x => x.IsVerified)
                .HasDefaultValue(false);

            // Unique constraints
            builder.HasIndex(x => x.Email)
                .IsUnique()
                .HasDatabaseName("UC_Account_Email");

            builder.HasIndex(x => x.UserName)
                .IsUnique()
                .HasDatabaseName("UC_Account_UserName");
        }
    }
}
