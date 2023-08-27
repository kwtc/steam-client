using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Kwtc.Steam.Client.Models.Details;
using Kwtc.Steam.Client.Models.List;

namespace Kwtc.Steam.Client;

public class SteamClient : ISteamClient
{
    private const string ApiUrl = "https://api.steampowered.com";
    private const string StoreUrl = "https://store.steampowered.com";
    private const string SteamKey = "STEAMKEY";

    public async Task<SteamAppDetailRootModel?> GetAppDetailsAsync(string id, CancellationToken cancellationToken)
    {
        var result = await StoreUrl
                           .AppendPathSegments("api", "appdetails")
                           .SetQueryParams(new { appids = id })
                           .GetJsonAsync<Dictionary<string, SteamAppDetailRootModel>>(cancellationToken);

        if (result == null)
        {
            return null;
        }

        return !result.TryGetValue(id, out var appDetails)
            ? null
            : appDetails;
    }

    public async Task<string?> GetAppDetailsJsonAsync(string id, CancellationToken cancellationToken = default)
    {
        return await StoreUrl
                     .AppendPathSegments("api", "appdetails")
                     .SetQueryParams(new { appids = id })
                     .GetStringAsync(cancellationToken);
    }

    public async Task<SteamAppListRootModel?> GetAppListAsync(CancellationToken cancellationToken)
    {
        return await ApiUrl
                     .AppendPathSegments("ISteamApps", "GetAppList", "v0002")
                     .SetQueryParams(new { key = SteamKey, format = "json" })
                     .GetJsonAsync<SteamAppListRootModel>(cancellationToken);
    }

    public async Task<string?> GetAppListJsonAsync(CancellationToken cancellationToken)
    {
        return await ApiUrl
                     .AppendPathSegments("ISteamApps", "GetAppList", "v0002")
                     .SetQueryParams(new { key = SteamKey, format = "json" })
                     .GetStringAsync(cancellationToken);
    }
}
