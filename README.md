# ToDoListApp
Todo List Application Documentation 
Project Overview 
This Todo List application is a simple web-based task management system built using ASP.NET Core with Razor Pages. It allows users to create, read, update, and delete todo items through a clean, straightforward interface. 

Technical Specifications 

    ● Framework: ASP.NET Core 8.0 
    
    ● Architecture: Razor Pages 
    
    ● Data Storage: In-memory collection (List<TodoItem>) 
    
    ● Frontend: HTML, CSS (Bootstrap), and JavaScript 
    
    ● Development Environment: Visual Studio 2022 
    
Features 
The application provides the following features: 
1.	View Todo Items: Lists all todo items in a tabular format 
2.	Add Todo Items: Create new tasks with a title and completion status 
3.	Edit Todo Items: Modify existing task details 
4.	Delete Todo Items: Remove tasks from the list 
5.	Toggle Status: Mark tasks as completed or pending with a single click
   
Project Structure 

●	TodoListApp/ 

●	├── Models/

●	│   └── TodoItem.cs            # Data model for todo items 

●	├── Pages/ 
●	│   ├── Create.cshtml          # Page for adding new todos 

●	│   ├── Create.cshtml.cs       # Code-behind for Create page 

●	│   ├── Edit.cshtml            # Page for editing existing todos 

●	│   ├── Edit.cshtml.cs         # Code-behind for Edit page 

●	│   ├── Index.cshtml           # Main listing page 

●	│   ├── Index.cshtml.cs        # Code-behind for Index page

●	│   └── Shared/

●	│       └── _Layout.cshtml     # Shared layout template

●	├── Services/

●	│   └── TodoItemService.cs     # Service for CRUD operations

●   └── Program.cs                 # Application configuration

 
Components 

Models 

TodoItem.cs 

Defines the data structure for todo items with the following properties: 

●	Id: Unique identifier 

●	Title: Description of the task 

●	IsCompleted: Status of the task (completed or pending) 

●	CreatedDate: When the task was created 


Services 

TodoItemService.cs 

Manages todo items in memory with the following methods: 

●	GetAllItems(): Retrieves all items 

●	GetItemById(int id): Finds a specific item 

●	AddTodoItem(TodoItem item): Creates a new item

●	UpdateTodoItem(TodoItem item): Modifies an existing item 

●	DeleteTodoItem(int id): Removes an item 


Pages 

Index.cshtml 

The main page displaying all todo items with options to:

●	View all tasks in a table 

●	Toggle the completion status of tasks 

●	Navigate to edit/create pages 

●	Delete tasks


Create.cshtml 

Form for adding new todo items with:

●	Title input field 

●	Completion status checkbox 

●	Save and Cancel buttons 


Edit.cshtml 

Form for modifying existing todo items with:

●	Pre-populated title field 

●	Completion status checkbox 

●	Save and Cancel buttons 


Implementation Details


Data Management 

●	Data is stored in-memory using a singleton service

●	The service is registered in Program.cs using dependency injection

●	Sample data is loaded when the application starts 


User Interface 
●	Clean, responsive design using Bootstrap 
●	Intuitive controls for all CRUD operations 
●	Visual indicators for task status (completed/pending) 
●	Confirmation dialogs for dangerous actions (e.g., deletion) 


Page Handlers 

●	OnGet(): Loads data when the page is accessed

●	OnPost(): Processes form submissions 

●	OnPostDelete(): Handles deletion requests 

●	OnPostToggleStatus(): Updates task completion status 



Testing

The application has been tested thoroughly to ensure that all CRUD operations work correctly.
Manual Testing Steps:

1.	Adding a Todo Item:
   
o	Navigate to the "Add Todo" page (/Todo/Create).
o	Enter a title and click "Add".
o	Verify that the item appears in the list.

2.	Viewing the Todo List:
   
o	Navigate to the main page (/Todo/Index).
o	Confirm that all added items are displayed.

3.	Editing a Todo Item:
   
o	Click on the "Edit" button for a task.
o	Modify the title and update.
o	Verify that changes reflect correctly.

4.	Deleting a Todo Item:
   
o	Click the "Delete" button next to an item.
o	Confirm deletion if prompted.
o	Ensure that the item is removed from the list.

5.	Toggling Task Status:
    
o	Click on a task’s completion checkbox.
o	Ensure that the status updates correctly.


Setup and Deployment 
Local Development 
1.	Clone the repository 
2.	Open the solution in Visual Studio 2022 
3.	Press F5 to run the application 
4.	Access the application at https://localhost:7037/
   
Deployment
The application can be deployed to: 
●	Azure App Service 
●	IIS 
●	Docker containers 

Conclusion 
This Todo List application demonstrates the simplicity and effectiveness of ASP.NET Core Razor Pages for building CRUD applications. Its clean architecture and straightforward implementation make it an excellent starting point for more complex task management systems. 
 
 
