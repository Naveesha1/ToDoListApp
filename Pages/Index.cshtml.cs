using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoListApp.Models;
using TodoListApp.Services;

namespace TodoListApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TodoItemService _todoService;

        public IndexModel(TodoItemService todoService)
        {
            _todoService = todoService;
        }

        public List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();

        public void OnGet()
        {
            TodoItems = _todoService.GetAllItems();
        }

        public IActionResult OnPostDelete(int id)
        {
            _todoService.DeleteTodoItem(id);
            return RedirectToPage();
        }

        public IActionResult OnPostToggleStatus(int id)
        {
            var item = _todoService.GetItemById(id);
            if (item != null)
            {
                item.IsCompleted = !item.IsCompleted;
                _todoService.UpdateTodoItem(item);
            }
            return RedirectToPage();
        }
    }
}