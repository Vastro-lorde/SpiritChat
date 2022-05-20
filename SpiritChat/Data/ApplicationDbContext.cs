using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpiritChat.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpiritChat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>()
                .HasOne<User>(e => e.Sender)
                .WithMany(d => d.Messages)
                .HasForeignKey(d => d.UserId);
        }
        public DbSet<Message> Messages { get; set; }
    }
}
