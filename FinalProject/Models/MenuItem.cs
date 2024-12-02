using System.Text.Json.Serialization;

namespace FinalProject;

public class MenuItem
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("price")]
    public double Price { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }
}