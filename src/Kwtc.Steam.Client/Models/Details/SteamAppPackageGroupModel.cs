using System.Collections.Generic;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppPackageGroupModel
{
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? SelectionText { get; set; }
    public string? SaveText { get; set; }
    public string? DisplayType { get; set; }
    public bool? IsRecurringSubscription { get; set; }
    public IEnumerable<SteamAppGroupSubscriptionModel>? Subscriptions { get; set; }
}