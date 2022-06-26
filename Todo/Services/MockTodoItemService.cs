using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Models;
namespace Todo.Services
{
    public class MockTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item2 = new TodoItem
            {
                Title = "Build useful apps",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}