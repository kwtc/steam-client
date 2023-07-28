using System.Collections.Generic;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppDetailDataModel
{
    public string? Type { get; set; }

    public string? Name { get; set; }

    public int? SteamAppId { get; set; }

    public string? RequiredAge { get; set; }

    public bool? IsFree { get; set; }

    public string? DetailedDescription { get; set; }

    public string? AboutTheGame { get; set; }

    public string? ShortDescription { get; set; }

    public SteamAppFullGameModel? FullGame { get; set; }

    public string? SupportedLanguages { get; set; }

    public string? HeaderImage { get; set; }

    public string? Website { get; set; }

    public dynamic? PcRequirements { get; set; }

    public dynamic? MacRequirements { get; set; }

    public dynamic? LinuxRequirements { get; set; }

    public string? LegalNotice { get; set; }

    public IEnumerable<string>? Developers { get; set; }

    public IEnumerable<string>? Publishers { get; set; }

    public SteamAppPriceOverviewModel? PriceOverview { get; set; }

    public IEnumerable<int>? Packages { get; set; }

    public IEnumerable<SteamAppPackageGroupModel>? PackageGroups { get; set; }

    public SteamAppPlatformModel? Platforms { get; set; }

    public IEnumerable<SteamAppIdDescriptionModel>? Categories { get; set; }

    public IEnumerable<SteamAppIdDescriptionModel>? Genres { get; set; }

    public IEnumerable<SteamAppScreenshotModel>? Screenshots { get; set; }

    public SteamAppReleaseDateModel? ReleaseDate { get; set; }

    public SteamAppSupportInfoModel? SupportInfo { get; set; }

    public string? BackgroundUrl { get; set; }

    public SteamAppContentDescriptorsModel? ContentDescriptors { get; set; }
}