using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppAchievementsModel
{
    [JsonPropertyName("total")]
    public int? Total { get; set; }
    
    [JsonPropertyName("highlighted")]
    public IEnumerable<SteamAppHighlightedModel>? Highlighted { get; set; }
}
