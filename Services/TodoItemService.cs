using TodoListApp.Models;

namespace TodoListApp.Services
{
    public class TodoItemService
    {
        private readonly List<TodoItem> _todoItems = new List<TodoItem>();
        private int _nextId = 1;

        public TodoItemService()
        {
            // Add some sample data
            AddTodoItem(new TodoItem { Title = "Learn ASP.NET Core" });
            AddTodoItem(new TodoItem { Title = "Build a Todo App" });
            AddTodoItem(new TodoItem { Title = "Deploy to GitHub" });
        }

        public List<TodoItem> GetAllItems()
        {
            return _todoItems;
        }

        public TodoItem? GetItemById(int id)
        {
            return _todoItems.FirstOrDefault(item => item.Id == id);
        }

        public void AddTodoItem(TodoItem item)
        {
            item.Id = _nextId++;
            _todoItems.Add(item);
        }

        public void UpdateTodoItem(TodoItem item)
        {
            var existingItem = GetItemById(item.Id);
            if (existingItem != null)
            {
                existingItem.Title = item.Title;
                existingItem.IsCompleted = item.IsCompleted;
            }
        }

        public void DeleteTodoItem(int id)
        {
            var item = GetItemById(id);
            if (item != null)
            {
                _todoItems.Remove(item);
            }
        }
    }
}