# Blazor Inventory Management Project

## Overview
This project is a Blazor application for managing inventory, with a focus on CRUD operations and database interactions using Entity Framework Core. Below, you'll find key syntax notes and relevant information to help you understand and work with the Blazor framework and the project's structure.

## before Set star proyect Database Entity Framework Core Commands
To set up and update your database schema, use the following commands:
```powershell
PM> add-migration AddData
PM> update-database


## Blazor Syntax and Key Notes
One-way Binding: Use @ to bind C# variables to the UI.
Two-way Binding: Use @bind to enable two-way data binding.
Event Handling: Use @on[event] to handle events (e.g., @onclick).
Routing: Use @page "/route" to define a component's route.
Dependency Injection: Use @inject to inject services into a component.
@inject NavigationManager NavManager  for navigate functionalities


Improving and Paginating a Grid
For improving and paginating a grid in Blazor, refer to this https://ankitsharmablogs.com/blazorgrid-reusable-grid-component-for-blazor/

