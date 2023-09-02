using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppPriceOverviewModel
{
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }
    
    [JsonPropertyName("initial")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? Initial { get; set; }
    
    [JsonPropertyName("final")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? Final { get; set; }
    
    [JsonPropertyName("discount_percent")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public int? DiscountPercentage { get; set; }
    
    [JsonPropertyName("initial_formatted")]
    public string? InitialFormatted { get; set; }
    
    [JsonPropertyName("final_formatted")]
    public string? FinalFormatted { get; set; }
}