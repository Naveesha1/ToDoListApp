using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoListApp.Models;
using TodoListApp.Services;

namespace TodoListApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly TodoItemService _todoService;

        public CreateModel(TodoItemService todoService)
        {
            _todoService = todoService;
        }

        [BindProperty]
        public TodoItem TodoItem { get; set; } = new TodoItem();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _todoService.AddTodoItem(TodoItem);
            return RedirectToPage("./Index");
        }
    }
}