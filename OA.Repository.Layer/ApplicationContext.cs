using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.DomainEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repository.Layer
{
   public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> option ): base(option) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());
        }
    }
}
