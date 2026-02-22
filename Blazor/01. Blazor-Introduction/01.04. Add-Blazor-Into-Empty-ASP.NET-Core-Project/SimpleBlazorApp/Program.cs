namespace SimpleBlazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorComponents()   // add Razor components
                .AddInteractiveServerComponents();  // add interactive server components

            var app = builder.Build();

            app.UseAntiforgery();                   // use Antiforgery middleware

            app.MapRazorComponents<App>()           // set base component
                .AddInteractiveServerRenderMode();  // add interactive server rendering mode

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
