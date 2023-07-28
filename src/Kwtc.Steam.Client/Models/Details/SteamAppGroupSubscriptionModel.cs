namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppGroupSubscriptionModel
{
    public int? PackageId { get; set; }
    public string? PercentSavingsText { get; set; }
    public int? PercentSavings { get; set; }
    public string? OptionText { get; set; }
    public string? OptionDescription { get; set; }
    public string? CanGetFreeLicense { get; set; }
    public bool? IsFreeLicense { get; set; }
    public int? PriceInCentsWithDiscount { get; set; }
}