using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class TodoDbContext : DbContext
    {
        public DbSet<ToDo> Todo { get; set; }
        public TodoDbContext(DbContextOptions<TodoDbContext> options)
         : base(options)
        { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //I tried to create model builder here
            modelBuilder.Entity<ToDo>().HasData(new ToDo { Title = "Swimming", IsCompleted = true });
            modelBuilder.Entity<ToDo>().HasData(new ToDo { Title = "Play Chess", IsCompleted = false });
            modelBuilder.Entity<ToDo>().HasData(new ToDo { Title = "Watch Movies", IsCompleted = true });
            modelBuilder.Entity<ToDo>().HasData(new ToDo { Title = "Worship", IsCompleted = false });
            modelBuilder.Entity<ToDo>().HasData(new ToDo { Title = "Lecture", IsCompleted = false });
            modelBuilder.Entity<ToDo>().HasData(new ToDo { Title = "Meal time", IsCompleted = true });
        }

    }
}
