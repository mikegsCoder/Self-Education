using BlazorApiInteractionApp;
using BlazorApiInteractionApp.Components;

// initial data:
List<Person> users = [
    new() { Id = Guid.NewGuid().ToString(), Name = "Tom", Age = 37 },
    new() { Id = Guid.NewGuid().ToString(), Name = "Bob", Age = 41 },
    new() { Id = Guid.NewGuid().ToString(), Name = "Sam", Age = 24 }
];

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();

var app = builder.Build();

app.UseAntiforgery();

// get all users:
app.MapGet("/api/users", () => users);

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();