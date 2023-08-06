using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppMovieFormatModel
{
    [JsonPropertyName("480")]
    public string? R480 { get; set; }
    
    [JsonPropertyName("max")]
    public string? Max { get; set; }
}
