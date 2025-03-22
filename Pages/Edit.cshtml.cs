using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoListApp.Models;
using TodoListApp.Services;

namespace TodoListApp.Pages
{
    public class EditModel : PageModel
    {
        private readonly TodoItemService _todoService;

        public EditModel(TodoItemService todoService)
        {
            _todoService = todoService;
        }

        [BindProperty]
        public TodoItem TodoItem { get; set; } = new TodoItem();

        public IActionResult OnGet(int id)
        {
            var item = _todoService.GetItemById(id);
            if (item == null)
            {
                return RedirectToPage("./Index");
            }

            TodoItem = item;
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _todoService.UpdateTodoItem(TodoItem);
            return RedirectToPage("./Index");
        }
    }
}