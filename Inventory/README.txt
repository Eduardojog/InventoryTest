# Blazor Inventory Management Project

## Overview
This project is a Blazor application for managing inventory, with a focus on CRUD operations and database interactions using Entity Framework Core. Below, you'll find key syntax notes and relevant information to help you understand and work with the Blazor framework and the project's structure.

## Setting Up the Project Database with Entity Framework Core
To set up and update your database schema, use the following commands:

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