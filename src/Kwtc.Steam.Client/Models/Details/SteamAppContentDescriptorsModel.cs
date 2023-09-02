using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppContentDescriptorsModel
{
    [JsonPropertyName("ids")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public IEnumerable<int>? Ids { get; set; }
    
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }
}