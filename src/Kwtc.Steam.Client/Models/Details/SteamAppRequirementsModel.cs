using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppRequirementsModel
{
    [JsonPropertyName("minimum")]
    public string Minimum { get; set; } = default!;
    
    [JsonPropertyName("recommended")]
    public string Recommended { get; set; } = default!;
}
