using Microsoft.EntityFrameworkCore;
using System.Entity;

namespace System.EFCore
{
    public class MSDBContext : DbContext
    {
        public MSDBContext(DbContextOptions<MSDBContext> options) :base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasMany(p => p.Employees).WithOne(q => q.Company).HasForeignKey(x => x.CompanyId);
            modelBuilder.Entity<Employee>().HasOne(p => p.Company).WithMany(q => q.Employees).HasForeignKey(x => x.CompanyId); 
            //base.OnModelCreating(modelBuilder);
        }
    }
}
