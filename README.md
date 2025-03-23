# ToDo List Application

## Project Overview
This Todo List application is a simple web-based task management system built using ASP.NET Core with Razor Pages. It allows users to **Create, Read, Update, and Delete (CRUD)** todo items through a clean, straightforward interface.

## Technical Specifications

- **Framework**: ASP.NET Core 8.0  
- **Architecture**: Razor Pages  
- **Data Storage**: In-memory collection (`List<TodoItem>`)  
- **Frontend**: HTML, CSS (Bootstrap), and JavaScript  
- **Development Environment**: Visual Studio 2022  

---

## Features
- **View Todo Items**: Lists all tasks in a tabular format.
- **Add Todo Items**: Create new tasks with a title and completion status.
- **Edit Todo Items**: Modify existing task details.
- **Delete Todo Items**: Remove tasks from the list.
- **Toggle Status**: Mark tasks as completed or pending with a single click.

---

## Project Structure
```
ToDoListApp/
│── Models/
│   └── TodoItem.cs           # Data model for todo items
│
│── Pages/
│   ├── Create.cshtml         # Page for adding new todos
│   ├── Create.cshtml.cs      # Code-behind for Create page
│   ├── Edit.cshtml           # Page for editing existing todos
│   ├── Edit.cshtml.cs        # Code-behind for Edit page
│   ├── Index.cshtml          # Main listing page
│   ├── Index.cshtml.cs       # Code-behind for Index page
│   └── Shared/
│       └── _Layout.cshtml    # Shared layout template
│
│── Services/
│   └── TodoItemService.cs    # Service for CRUD operations
│
└── Program.cs                # Application configuration
```

---

## Components

### 1. Models
#### `TodoItem.cs`
Defines the data structure for todo items:
- `Id`: Unique identifier
- `Title`: Description of the task
- `IsCompleted`: Status of the task (completed or pending)
- `CreatedDate`: When the task was created

### 2. Services
#### `TodoItemService.cs`
Manages todo items in memory with methods:
- `GetAllItems()`: Retrieves all items
- `GetItemById(int id)`: Finds a specific item
- `AddTodoItem(TodoItem item)`: Creates a new item
- `UpdateTodoItem(TodoItem item)`: Modifies an existing item
- `DeleteTodoItem(int id)`: Removes an item

### 3. Pages
#### `Index.cshtml`
Main page displaying all tasks with options to:
- View all tasks
- Toggle task completion
- Edit and delete tasks

#### `Create.cshtml`
Form for adding new todo items:
- Title input field
- Completion status checkbox
- Save and Cancel buttons

#### `Edit.cshtml`
Form for modifying existing tasks:
- Pre-populated title field
- Completion status checkbox
- Save and Cancel buttons

---

## Implementation Details

### Data Management
- Data is stored in-memory using a singleton service.
- The service is registered in `Program.cs` using dependency injection.
- Sample data is loaded when the application starts.

### User Interface
- Responsive design using Bootstrap.
- Intuitive controls for CRUD operations.
- Visual indicators for task status.
- Confirmation dialogs for deletions.

### Page Handlers
- `OnGet()`: Loads data when the page is accessed.
- `OnPost()`: Processes form submissions.
- `OnPostDelete()`: Handles deletion requests.
- `OnPostToggleStatus()`: Updates task completion status.

---

## Testing
The application has been tested to ensure CRUD operations function correctly.
### Manual Testing Steps:
1. **Adding a Todo Item**:
   - Navigate to `/Create`.
   - Enter a title and click "Add".
   - Verify that the item appears in the list.

2. **Viewing the Todo List**:
   - Navigate to `/Index`.
   - Confirm that all added items are displayed.

3. **Editing a Todo Item**:
   - Click on "Edit" for a task.
   - Modify the title and update.
   - Verify changes are reflected.

4. **Deleting a Todo Item**:
   - Click the "Delete" button next to a task.
   - Confirm deletion.
   - Ensure the task is removed.

5. **Toggling Task Status**:
   - Click on a task’s completion checkbox.
   - Ensure the status updates correctly.

---

## Setup and Deployment

### Local Development
1. Clone the repository:
   ```sh
   git clone <repository-url>
   ```
2. Open the solution in Visual Studio 2022.
3. Press **F5** to run the application.
4. Access the app at: `https://localhost:7037/`.

### Deployment
The application can be deployed to:
- **Azure App Service**
- **IIS**
- **Docker Containers**

---

## Conclusion
This Todo List application demonstrates the simplicity and effectiveness of **ASP.NET Core Razor Pages** for building CRUD applications. Its clean architecture and straightforward implementation make it an excellent starting point for more advanced task management systems.

---

### Author
**Naveesha Ekanayake**
