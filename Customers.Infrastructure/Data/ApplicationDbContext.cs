using Customers.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Customers.Infrastructure
{   
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }

            public DbSet<Customer> Customers { get; set; }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
            }
        }
   
}
