using Microsoft.EntityFrameworkCore;
using System.Entity;

namespace System.EFCore
{
    public class MSDBContext : DbContext
    {
        public MSDBContext(DbContextOptions<MSDBContext> options) :base(options)
        {

        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
