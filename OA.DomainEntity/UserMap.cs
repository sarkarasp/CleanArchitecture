using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.DomainEntity
{
   public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> typeBuilder)
        {
            typeBuilder.HasKey(t => t.Id);
            typeBuilder.Property(t => t.Email).IsRequired();
            typeBuilder.Property(t => t.Password).IsRequired();
            typeBuilder.HasOne(e => e.userProfile).WithOne(u => u.user).HasForeignKey<UserProfile>(x => x.Id);
        }
    }
}
