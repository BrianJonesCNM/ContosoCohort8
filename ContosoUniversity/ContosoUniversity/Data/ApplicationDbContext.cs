using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Identity;

namespace ContosoUniversity.Data
{
    public class ApplicationDbContext
    : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>(b =>
            {
                b.HasMany(y => y.Claims)
                .WithOne()
                .HasForeignKey(fk => fk.Id)
                .IsRequired();
            });
        }
    }
}
