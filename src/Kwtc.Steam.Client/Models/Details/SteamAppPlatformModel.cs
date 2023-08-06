using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppPlatformModel
{
    [JsonPropertyName("windows")]
    public bool? Windows { get; set; }
    
    [JsonPropertyName("mac")]
    public bool? Mac { get; set; }
    
    [JsonPropertyName("linux")]
    public bool? Linux { get; set; }
}