using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppReleaseDateModel
{
    [JsonPropertyName("coming_soon")]
    public bool? ComingSoon { get; set; }
    
    [JsonPropertyName("date")]
    public string? Date { get; set; }
}