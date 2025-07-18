using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.DataContext
{
    public class LibraryContext(DbContextOptions<LibraryContext> options) : DbContext(options)
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transaction>()
                .Property(x => x.TransactionStatus)
                .HasConversion<string>();
            //    modelBuilder.Entity<User>()
            //        .HasData(new User { Email = "fortunateomonuwa@gmail.com", MembershipNumber = 1, Name = "Admin", Password = "admin123", Id = Guid.NewGuid() });
        }
    }
}
