﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Services
{
	public interface ITodoItemService
	{
		Task<TodoItem[]> GetIncompleteItemsAsync();
	}
}
