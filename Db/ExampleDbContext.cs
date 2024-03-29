using Microsoft.EntityFrameworkCore;
using Domain.User;

namespace Db
{
    public class ExampleDbContext : DbContext
    {
        public ExampleDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=exampleentity;Username=postgres;Password=password");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasKey(x => x.Id);
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserAddress> Addresses { get; set; }
    }
}
