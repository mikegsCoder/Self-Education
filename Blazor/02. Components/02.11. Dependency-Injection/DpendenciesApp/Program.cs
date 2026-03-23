using DpendenciesApp;
using DpendenciesApp.Components;
using DpendenciesApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add Services:
builder.Services.AddTransient<ITimeService, TimeService>();
builder.Services.AddTransient<TimeFormatService>();

// Show all default services:
Console.WriteLine("Blazor default services:");

foreach (var service in builder.Services)
{
    Console.WriteLine(service.ServiceType);
}

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

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
