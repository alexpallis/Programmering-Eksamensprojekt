using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Programmering_Eksamensprojekt;
using System.Text.Json;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

class Testing
{
    static void Main(string[] args)
    {
        // Read JSON file
        string json = File.ReadAllText("TestFile1.json");

        Størrelse størrelse = JsonSerializer.Deserialize<Størrelse>(json);

        Console.WriteLine($"Masse:{størrelse.Masse}");
    }
}