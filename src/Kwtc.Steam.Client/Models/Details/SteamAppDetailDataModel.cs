using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppDetailDataModel
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("steam_appid")]
    public int? Id { get; set; }

    /// <summary>
    /// This is dynamic because it can be 0 or a string ¯\_(ツ)_/¯.
    /// </summary>
    [JsonPropertyName("required_age")]
    public dynamic? RequiredAge { get; set; }

    [JsonPropertyName("is_free")]
    public bool? IsFree { get; set; }

    [JsonPropertyName("controller_support")]
    public string? ControllerSupport { get; set; }
    
    [JsonPropertyName("dlc")]
    public IEnumerable<int>? Dlc { get; set; }
    
    [JsonPropertyName("detailed_description")]
    public string? DetailedDescription { get; set; }

    [JsonPropertyName("about_the_game")]
    public string? AboutTheGame { get; set; }

    [JsonPropertyName("short_description")]
    public string? ShortDescription { get; set; }

    [JsonPropertyName("fullgame")]
    public SteamAppFullGameModel? FullGame { get; set; }

    [JsonPropertyName("supported_languages")]
    public string? SupportedLanguages { get; set; }

    [JsonPropertyName("header_image")]
    public string? HeaderImage { get; set; }
    
    [JsonPropertyName("capsule_image")]
    public string? CapsuleImage { get; set; }
    
    [JsonPropertyName("capsule_imagev5")]
    public string? CapsuleImageV5 { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }
    
    /// <summary>
    /// This is dynamic because it can be an empty array (if not defined) or an object ¯\_(ツ)_/¯.
    /// </summary>
    [JsonPropertyName("pc_requirements")]
    public dynamic? PcRequirements { get; set; }

    /// <summary>
    /// This is dynamic because it can be an empty array (if not defined) or an object ¯\_(ツ)_/¯.
    /// </summary>
    [JsonPropertyName("mac_requirements")]
    public dynamic? MacRequirements { get; set; }

    /// <summary>
    /// This is dynamic because it can be an empty array (if not defined) or an object ¯\_(ツ)_/¯.
    /// </summary>
    [JsonPropertyName("linux_requirements")]
    public dynamic? LinuxRequirements { get; set; }

    [JsonPropertyName("legal_notice")]
    public string? LegalNotice { get; set; }
    
    [JsonPropertyName("drm_notice")]
    public string? DrmNotice { get; set; }
    
    [JsonPropertyName("ext_user_account_notice")]
    public string? ExistingUserAccountNotice { get; set; }

    [JsonPropertyName("developers")]
    public IEnumerable<string>? Developers { get; set; }

    /// <summary>
    /// Can actually contain a single empty string value (I'm guessing if the app is self published) ¯\_(ツ)_/¯.
    /// </summary>
    [JsonPropertyName("publishers")]
    public IEnumerable<string>? Publishers { get; set; }
    
    [JsonPropertyName("demos")]
    public IEnumerable<SteamAppDemoDescriptionModel>? Demos { get; set; }

    [JsonPropertyName("price_overview")]
    public SteamAppPriceOverviewModel? PriceOverview { get; set; }

    [JsonPropertyName("packages")]
    public IEnumerable<int>? Packages { get; set; }

    [JsonPropertyName("package_groups")]
    public IEnumerable<SteamAppPackageGroupModel>? PackageGroups { get; set; }

    [JsonPropertyName("platforms")]
    public SteamAppPlatformModel? Platforms { get; set; }

    [JsonPropertyName("categories")]
    public IEnumerable<SteamAppIdIntDescriptionModel>? Categories { get; set; }

    [JsonPropertyName("genres")]
    public IEnumerable<SteamAppIdStringDescriptionModel>? Genres { get; set; }

    [JsonPropertyName("screenshots")]
    public IEnumerable<SteamAppScreenshotModel>? Screenshots { get; set; }
    
    [JsonPropertyName("movies")]
    public IEnumerable<SteamAppMovieModel>? Movies { get; set; }

    [JsonPropertyName("recommendations")]
    public SteamAppRecommendationsModel? Recommendations { get; set; }
    
    [JsonPropertyName("achievements")]
    public SteamAppAchievementsModel? Achievements { get; set; }
    
    [JsonPropertyName("release_date")]
    public SteamAppReleaseDateModel? ReleaseDate { get; set; }

    [JsonPropertyName("support_info")]
    public SteamAppSupportInfoModel? SupportInfo { get; set; }

    [JsonPropertyName("background")]
    public string? BackgroundUrl { get; set; }
    
    [JsonPropertyName("background_raw")]
    public string? BackgroundUrlRaw { get; set; }

    [JsonPropertyName("content_descriptors")]
    public SteamAppContentDescriptorsModel? ContentDescriptors { get; set; }
}