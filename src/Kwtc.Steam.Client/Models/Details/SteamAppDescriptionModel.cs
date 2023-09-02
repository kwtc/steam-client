using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppDescriptionModel
{
    [JsonPropertyName("id")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public int? Id { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}