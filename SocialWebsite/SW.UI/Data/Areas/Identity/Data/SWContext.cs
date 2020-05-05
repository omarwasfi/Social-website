using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SW.UI.Areas.Identity.Data;

namespace SW.UI.Data
{
    public class SWContext : IdentityDbContext<Person>
    {
        public DbSet<Group> Groups { get; set; }

        public DbSet<PersonGroup>  PersonGroups { get; set; }

        public DbSet<PersonGroupAdmin> PersonGroupAdmins { get; set; }

        public DbSet<Chat> Chats { get; set; }

        public DbSet<PersonChat> PersonChats { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<TextPost> TextPosts { get; set; }

        public DbSet<PhotoPost> PhotoPosts { get; set; }

        public DbSet<VideoPost> VideoPosts { get; set; }

        public SWContext(DbContextOptions<SWContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            
            builder.Entity<PersonGroup>().HasKey(x => new { x.GroupId, x.PersonId });

            builder.Entity<PersonGroup>()
                .HasOne(x => x.Person)
                .WithMany(y => y.PersonGroups)
                .HasForeignKey(x => x.PersonId);

            builder.Entity<PersonGroup>()
                .HasOne(x => x.Group)
                .WithMany(b => b.PersonGroups)
                .HasForeignKey(x => x.GroupId);


            builder.Entity<PersonGroupAdmin>().HasKey(x => new { x.GroupId, x.PersonId });

            builder.Entity<PersonGroupAdmin>()
                .HasOne(x => x.Person)
                .WithMany(y => y.PersonGroupAdmins)
                .HasForeignKey(x => x.PersonId);

            builder.Entity<PersonGroupAdmin>()
                .HasOne(x => x.Group)
                .WithMany(b => b.PersonGroupAdmins)
                .HasForeignKey(x => x.GroupId);


            builder.Entity<PersonChat>().HasKey(x => new { x.ChatId, x.PersonId });

            builder.Entity<PersonChat>()
                .HasOne(x => x.Person)
                .WithMany(y => y.PersonChats)
                .HasForeignKey(x => x.PersonId);

            builder.Entity<PersonChat>()
                .HasOne(x => x.Chat)
                .WithMany(b => b.PersonChats)
                .HasForeignKey(x => x.ChatId);


            builder.Entity<PersonTextPost>().HasKey(x => new { x.TextPostId, x.PersonId });

            builder.Entity<PersonTextPost>()
                .HasOne(x => x.Person)
                .WithMany(y => y.PersonTextPosts)
                .HasForeignKey(x => x.PersonId);

            builder.Entity<PersonTextPost>()
                .HasOne(x => x.TextPost)
                .WithMany(b => b.PersonTextPosts)
                .HasForeignKey(x => x.TextPostId);

            builder.Entity<PersonVideoPost>().HasKey(x => new { x.VideoPostId, x.PersonId });

            builder.Entity<PersonVideoPost>()
                .HasOne(x => x.Person)
                .WithMany(y => y.PersonVideoPosts)
                .HasForeignKey(x => x.PersonId);

            builder.Entity<PersonVideoPost>()
                .HasOne(x => x.VideoPost)
                .WithMany(b => b.PersonVideoPosts)
                .HasForeignKey(x => x.VideoPostId);


            builder.Entity<PersonPhotoPost>().HasKey(x => new { x.PhotoPostId, x.PersonId });

            builder.Entity<PersonPhotoPost>()
                .HasOne(x => x.Person)
                .WithMany(y => y.PersonPhotoPosts)
                .HasForeignKey(x => x.PersonId);

            builder.Entity<PersonPhotoPost>()
                .HasOne(x => x.PhotoPost)
                .WithMany(b => b.PersonPhotoPosts)
                .HasForeignKey(x => x.PhotoPostId);
        }
    }
}
