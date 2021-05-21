using Microsoft.EntityFrameworkCore;
using TodoApi.Configurations;

namespace TodoApi.Models
{
    //This Class is responsible for the communication between the process and the DataBase
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TodoItem).Assembly); //Option 1 of how to configure a Class to a Table
            //modelBuilder.ApplyConfiguration<TodoItem>(new ToDoConfiguration()); //Option 2
        }
    }
}