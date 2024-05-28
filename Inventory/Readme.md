# Inventory Management System

This solution helps manage inventory by allowing users to add products to warehouses. 
It uses Blazor for the front-end, along with Entity Framework Core for database operations.

## Features

- Add products to warehouses
- View products and warehouses
- Check if a product is already in a warehouse

## Prerequisites

- .NET 6 SDK or later
- Entity Framework Core
- Blazor


- 
betters grid
https://ankitsharmablogs.com/blazorgrid-reusable-grid-component-for-blazor/


Key Points for Creating a Blazor Page and Its Component
When working with Blazor to create web pages and components, it's important to remember the following key points:

Components:

Definition: Components are defined in .razor files.
Syntax: Combine C# code and HTML markup.
Parameters: Use [Parameter] to pass data to components.
Data Binding:

One-way Binding: Use @ to bind C# variables to the UI.
Two-way Binding: Use @bind to enable two-way data binding.
Event Handling:

Event Callbacks: Use @on to handle events (e.g., @onclick).
Methods: Define methods in the @code block and invoke them in the markup.
Dependency Injection:

@inject NavigationManager NavManager

Service Injection: Use @inject to inject services into components.
Registration: Register services in Startup.cs or Program.cs.
Lifecycle Methods:

Initialization: Use OnInitialized or OnInitializedAsync for initializing data.
State Changes: Use StateHasChanged to manually trigger a UI refresh.
Routing:

Route Templates: Define routes using the @page directive.
Navigation: Use NavigationManager to navigate between pages programmatically.
Forms and Validation:

EditForm: Use <EditForm> for form handling.
Validation: Use [Required], [StringLength], etc., for model validation.
Asynchronous Programming:

Async/Await: Use async/await for I/O-bound operations to keep the UI responsive.
State Management:

Local State: Manage state within components using local variables.
Shared State: Use services or state containers for shared state.
Performance:

Render Fragments: Use RenderFragment for efficient rendering.
Virtualization: Use <Virtualize> for rendering large lists efficiently.



``` NOTES for create database powershell
PM> add-migration AddData
PM> update-database


Blazor Syntax and Key Notes
Data Binding
One-way Binding: Use @ to bind C# variables to the UI.

<p>@variableName</p>
Two-way Binding: Use @bind to enable two-way data binding.

<input @bind="variableName" />
Event Handling
Event Handling: Use @on[event] to handle events (e.g., @onclick).

<button @onclick="EventHandlerMethod">Click me</button>
Routing
Routing: Use @page "/route" to define a component's route.

@page "/home"
Dependency Injection
Dependency Injection: Use @inject to inject services into a component.

@inject ServiceType ServiceName
For navigation functionalities, you can inject NavigationManager.

@inject NavigationManager NavManager
Improving and Paginating a Grid
For improving and paginating a grid in Blazor, refer to this resource:

Web::https://ankitsharmablogs.com/blazorgrid-reusable-grid-component-for-blazor/