using Microsoft.EntityFrameworkCore;

namespace MinimalApiExcercises;

public class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options) : base(options)
    {
        //Todos.AddRange(new Todo() { Id = 1, IsComplete = false, Name = "Ziemniaczki" },
        //    new Todo() { Id = 2, IsComplete = true, Name = "potato" },
        //    new Todo() { Id = 3, IsComplete = false, Name = "frytki" });
    }
    public DbSet<Todo> Todos => Set<Todo>();
}