namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppPriceOverviewModel
{
    public string? Currency { get; set; }
    public decimal? Initial { get; set; }
    public decimal? Final { get; set; }
    public int? DiscountPercentage { get; set; }
    public string? InitialFormatted { get; set; }
    public string? FinalFormatted { get; set; }
}