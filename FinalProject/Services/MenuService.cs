using System.Reflection;
using System.Text.Json;

namespace FinalProject;

public class MenuService
{
    public async Task<List<MenuItem>> ReadJsonCrossPlatformAsync()
    {
        try
        {
            string projectDirectory = "/Users/jiraj/Workspaces/project-test/FinalProject-pagemenu-/FinalProject/";
            string filePath = Path.Combine(
                projectDirectory,
                "Data",
                "menu.json"
            );

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found: {filePath}");
                return new List<MenuItem>();
            }

            string jsonString = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<MenuItem>>(jsonString)
                   ?? new List<MenuItem>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return new List<MenuItem>();
        }
    }
}
