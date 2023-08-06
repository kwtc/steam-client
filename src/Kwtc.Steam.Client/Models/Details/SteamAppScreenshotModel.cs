using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppScreenshotModel
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    
    [JsonPropertyName("path_thumbnail")]
    public string? PathThumbnailUrl { get; set; }
    
    [JsonPropertyName("path_full")]
    public string? PathFullUrl { get; set; }
}