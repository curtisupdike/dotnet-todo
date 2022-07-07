﻿using Todo.Models;

namespace Todo.Services
{
	public interface ITodoItemService
	{
		Task<TodoItem[]> GetIncompleteItemsAsync(ApplicationUser user);

		Task<bool> AddItemAsync(TodoItem newItem, ApplicationUser user);

		Task<bool> MarkDoneAsync(Guid id, ApplicationUser user);
	}
}

