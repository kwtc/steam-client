using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppDemoDescriptionModel
{
    [JsonPropertyName("appid")]
    public int? Id { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}
