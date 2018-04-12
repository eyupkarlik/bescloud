using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace besCenter.Models
{
    public class BESContext : DbContext
    {
        public BESContext(DbContextOptions<BESContext> options) : base(options)
        {
        }

        public DbSet<BESOrtak> BESOrtaks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BESOrtak>().ToTable("BESOrtak");
        }
    }
}
