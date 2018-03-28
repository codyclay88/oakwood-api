using System;
using Microsoft.EntityFrameworkCore;

namespace OakwoodApp.Entities
{
    public class OakwoodDbContext : DbContext
    {
        public OakwoodDbContext(DbContextOptions<OakwoodDbContext> options) : base(options)
        {

        }

        public DbSet<Ministry> Ministries { get; set; }
        public DbSet<OakwoodEvent> OakwoodEvents { get; set; }
        public DbSet<Leader> Leaders { get; set; }
    }
}