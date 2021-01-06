using System;
using BockernasHus.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BockernasHus.Repository
{
    public class BockernasHusDbContext : DbContext
    {
        public BockernasHusDbContext(DbContextOptions<BockernasHusDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<Models.Entities.Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>();
            modelBuilder.Entity<Book>();
            modelBuilder.Entity<Condition>();
            modelBuilder.Entity<Models.Entities.Type>();
        }
    }
}
