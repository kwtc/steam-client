using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppRecommendationsModel
{
    [JsonPropertyName("total")]
    public int? Total { get; set; }
}
