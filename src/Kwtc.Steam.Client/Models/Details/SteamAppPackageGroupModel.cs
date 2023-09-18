using System.Collections.Generic;
using System.Text.Json.Serialization;
using Kwtc.Steam.Client.Converters;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppPackageGroupModel
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("selection_text")]
    public string? SelectionText { get; set; }
    
    [JsonPropertyName("save_text")]
    public string? SaveText { get; set; }
    
    [JsonPropertyName("display_type")]
    [JsonConverter(typeof(NumberOrStringToStringConverter))]
    public string? DisplayType { get; set; }
    
    [JsonPropertyName("is_recurring_subscription")]
    public string? IsRecurringSubscription { get; set; }
    
    [JsonPropertyName("subs")]
    public IEnumerable<SteamAppGroupSubscriptionModel>? Subscriptions { get; set; }
}