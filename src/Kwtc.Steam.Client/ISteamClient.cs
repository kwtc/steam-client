using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Kwtc.Steam.Client.Models.Details;
using Kwtc.Steam.Client.Models.List;

namespace Kwtc.Steam.Client;

public interface ISteamClient
{
    /// <summary>
    /// Get the details of one or more Steam apps mapped to a model.
    /// </summary>
    /// <param name="ids">
    /// A collection of Steam app ids to get details for.
    /// The Steam API only supports multiple ids in combination with the <see cref="SteamFilters.PriceOverview"/> filter.
    /// </param>
    /// <param name="countryCode">Optional country code affecting prices.</param>
    /// <param name="language">Optional language.</param>
    /// <param name="filters">Optional collection of filters determining the details returned.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<Dictionary<string, SteamAppDetailRootModel>> GetAppDetailsAsync(
        List<string> ids,
        string? countryCode,
        string? language,
        List<string>? filters,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the details of a Steam app as a json string.
    /// </summary>
    /// /// <param name="ids">
    /// A collection of Steam app ids to get details for.
    /// The Steam API only supports multiple ids in combination with the <see cref="SteamFilters.PriceOverview"/> filter.
    /// </param>
    /// <param name="countryCode">Optional country code affecting prices.</param>
    /// <param name="language">Optional language.</param>
    /// <param name="filters">Optional collection of filters determining the details returned.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<string?> GetAppDetailsJsonAsync(
        List<string> ids,
        string? countryCode,
        string? language,
        List<string>? filters,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of all Steam apps mapped to a model.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<SteamAppListRootModel?> GetAppListAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of all Steam apps as a json string.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<string?> GetAppListJsonAsync(CancellationToken cancellationToken = default);
}