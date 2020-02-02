using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TodoApp.Models;

namespace TodoApp.DAL
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
    }

    public class TodoDbInitializer : DropCreateDatabaseAlways<TodoContext>
    {
        protected override void Seed(TodoContext context)
        {
            context.Todos.AddRange(new List<Todo> 
            {
                new Todo 
                { 
                    Id = 1, 
                    IsCompleted = true, 
                    Deadline = DateTime.Now, 
                    Priority = Priority.Low, 
                    Summary = "Buy milk and relax",
                    Category = "Food"
                },
                new Todo
                {
                    Id = 2,
                    IsCompleted = false,
                    Deadline = DateTime.Now,
                    Priority = Priority.Low,
                    Summary = "Complete all homeworks",
                    Category = "Study"
                },
                new Todo
                {
                    Id = 3,
                    IsCompleted = false,
                    Deadline = DateTime.Now,
                    Priority = Priority.Hight,
                    Summary = "To be cool",
                    Category = "Myself"
                },
                new Todo
                {
                    Id = 4,
                    IsCompleted = false,
                    Deadline = DateTime.Now,
                    Priority = Priority.Hight,
                    Summary = "Recive diploma and find a work!",
                    Category = "Study"
                },
                new Todo
                {
                    Id = 5,
                    IsCompleted = true,
                    Deadline = DateTime.Now,
                    Priority = Priority.Medium,
                    Summary = "Cook a borsch",
                    Category = "Food"
                },
                new Todo
                {
                    Id = 6,
                    IsCompleted = false,
                    Deadline = DateTime.Now,
                    Priority = Priority.Medium,
                    Summary = "Buy any company (e.x Apple or Google)",
                    Category = "Money"
                },
                new Todo
                {
                    Id = 7,
                    IsCompleted = false,
                    Deadline = DateTime.Now,
                    Priority = Priority.Low,
                    Summary = "Buy a toner for my printer",
                    Category = "Home"
                }
            });
            base.Seed(context);
        }
    }
}