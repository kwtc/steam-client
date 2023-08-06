using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppSupportInfoModel
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}