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

// get user by id:
app.MapGet("/api/users/{id}", (string id) =>
{
    Person? user = users.FirstOrDefault(u => u.Id == id);

    // if no such user send Error status code and message:
    if (user == null) return Results.NotFound("User not found!");

    // if user found send it:
    return Results.Json(user);
});

// delete user by id:
app.MapDelete("/api/users/{id}", (string id) =>
{
    // get user by id:
    Person? user = users.FirstOrDefault(u => u.Id == id);

    // if no such user send Error status code and message:
    if (user == null) return Results.NotFound("User not found!");

    // if user found delete it:
    users.Remove(user);
    return Results.Json(user);
});

// create user:
app.MapPost("/api/users", (Person user) =>
{
    // set new user id:
    user.Id = Guid.NewGuid().ToString();

    // add user into list:
    users.Add(user);
    return user;
});

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();