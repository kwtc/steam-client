using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppMovieModel
{
    [JsonPropertyName("id")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public int? Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }
    
    [JsonPropertyName("webm")]
    public SteamAppMovieFormatModel? Webm { get; set; }
    
    [JsonPropertyName("mp4")]
    public SteamAppMovieFormatModel? Mp4 { get; set; }
    
    [JsonPropertyName("highlight")]
    public bool? Highlight { get; set; }
}
