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

class SorterTest
{
    static void Main()
    {
        // Define available lists of units
        List<List<string>> unitGroups = new List<List<string>>
        {
            new List<string> { "A", "B", "C" },
            new List<string> { "A", "B" },
            new List<string> { "A", "C" },
            new List<string> { "B", "C" },
            new List<string> { "A", "B", "C", "D" } // This one has an extra unit and should be ignored
        };

        // Input required units
        HashSet<string> requiredUnits = new HashSet<string> { "A", "B" };

        // Find matching unit lists
        var matchingGroups = unitGroups
            .Where(group => new HashSet<string>(group).SetEquals(requiredUnits))
            .ToList();

        // Print results
        if (matchingGroups.Count > 0)
        {
            Console.WriteLine("Yuh:");
            foreach (var group in matchingGroups)
            {
                Console.WriteLine($"[{string.Join(", ", group)}]");
            }
        }
        else
        {
            Console.WriteLine("Nah.");
        }
        
    }
}