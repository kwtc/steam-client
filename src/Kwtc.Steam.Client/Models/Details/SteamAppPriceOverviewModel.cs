using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppPriceOverviewModel
{
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }
    
    [JsonPropertyName("initial")]
    public decimal? Initial { get; set; }
    
    [JsonPropertyName("final")]
    public decimal? Final { get; set; }
    
    [JsonPropertyName("discount_percent")]
    public int? DiscountPercentage { get; set; }
    
    [JsonPropertyName("initial_formatted")]
    public string? InitialFormatted { get; set; }
    
    [JsonPropertyName("final_formatted")]
    public string? FinalFormatted { get; set; }
}