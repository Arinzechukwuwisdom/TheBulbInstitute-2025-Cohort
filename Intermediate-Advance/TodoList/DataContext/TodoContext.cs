using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.DataContext
{
    public class TodoContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = Secrets.connectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
