using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using FirstProject.Models;
using Microsoft.AspNetCore.Identity;

namespace FirstProject.DAL
{


    public class MySqlContext : IdentityDbContext<ApplicationUser>
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

            this.Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            int stringMaxLength = 100 /* something like 100*/;
            // User IdentityRole and IdentityUser in case you haven't extended those classes
            //builder.Entity<IdentityRole>(x => x.Property(m => m.Name).HasMaxLength(stringMaxLength));
            //builder.Entity<IdentityRole>(x => x.Property(m => m.NormalizedName).HasMaxLength(stringMaxLength));
            //builder.Entity<ApplicationUser>(x => x.Property(m => m.NormalizedUserName).HasMaxLength(stringMaxLength));

            // We are using int here because of the change on the PK
            // builder.Entity<IdentityUserLogin<int>>(x => x.HasNoKey());
            //builder.Entity<IdentityUserLogin<int>>(x => x.Property(m => m.LoginProvider).HasMaxLength(stringMaxLength));
            //builder.Entity<IdentityUserLogin<int>>(x => x.Property(m => m.ProviderKey).HasMaxLength(stringMaxLength));

            // We are using int here because of the change on the PK
            // builder.Entity<IdentityUserToken<int>>(x => x.HasNoKey());
            //builder.Entity<IdentityUserToken<int>>(x => x.Property(m => m.LoginProvider).HasMaxLength(stringMaxLength));
            //builder.Entity<IdentityUserToken<int>>(x => x.Property(m => m.Name).HasMaxLength(stringMaxLength));

            // etc..


            // builder.Entity<ApplicationUser>().Property(u => u.UserName).HasMaxLength(128);

            //builder.Entity<ApplicationUser>().Property(u => u.UserName).HasMaxLength(128);

            //Uncomment this to have Email length 128 too (not neccessary)
            //modelBuilder.Entity<ApplicationUser>().Property(u => u.Email).HasMaxLength(128);

            //builder.Entity<IdentityRole>().Property(r => r.Name).HasMaxLength(128);

            builder.Entity<IdentityUser>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<IdentityUser>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(85));
            builder.Entity<IdentityUser>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(85));

            builder.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<IdentityRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(85));

            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(85));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));

            builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));

            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.Name).HasMaxLength(85));

            builder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));


        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<StudentDetails> StudentDetails { get; set; }

    }
}
