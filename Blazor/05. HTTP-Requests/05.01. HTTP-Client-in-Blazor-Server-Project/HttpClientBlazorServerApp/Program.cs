using HttpClientBlazorServerApp;
using HttpClientBlazorServerApp.Components;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();  // add HttpClient

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

// testing HTTP GET request:
// return time on HttpRequest at "/time"
app.MapGet("/time", () => DateTime.Now.ToShortTimeString());

// testing HTTP POST request:
app.MapPost("/user", (Person user) =>
{
    // Name must be between 3 and 20 characters long
    if (user.Name.Length < 3 || user.Name.Length > 20)
        return Results.BadRequest(new { details = "Name must be between 3 and 20 characters long." });
    
    // Age must be between 1 and 110
    if (user.Age < 1 || user.Age > 110)
        return Results.BadRequest(new { details = "Age must be between 1 and 110." });
    
    // if everything is ok set new user id
    user.Id = Guid.NewGuid().ToString();
    
    // send user object as JSON
    return Results.Json(user);
});

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
