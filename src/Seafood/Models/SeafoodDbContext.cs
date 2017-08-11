using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Seafood.Models
{
    public class SeafoodDbContext : DbContext
    {
        public SeafoodDbContext()
        { }

        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=seafood_scripts;integrated security=True");
        }

        public SeafoodDbContext(DbContextOptions<SeafoodDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
