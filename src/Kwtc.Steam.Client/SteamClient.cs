using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Kwtc.Steam.Client.Models.Details;
using Kwtc.Steam.Client.Models.List;
using Microsoft.Extensions.Options;

namespace Kwtc.Steam.Client;

public class SteamClient : ISteamClient
{
    private const string ApiUrl = "https://api.steampowered.com";
    private const string StoreUrl = "https://store.steampowered.com";

    private string steamKey;

    public SteamClient(IOptions<SteamConfig> config)
    {
        this.steamKey = config.Value.ApiKey;
    }

    public async Task<Dictionary<string, SteamAppDetailRootModel>> GetAppDetailsAsync(
        List<string> ids,
        string? countryCode,
        string? language,
        List<string>? filters,
        CancellationToken cancellationToken)
    {
        if (ids.Count == 0)
        {
            throw new InvalidEnumArgumentException("ids cannot be empty");
        }

        var result = await StoreUrl
            .AppendPathSegments("api", "appdetails")
            .SetQueryParams(GetAppDetailQueryParams(ids, countryCode, language, filters))
            .GetJsonAsync<Dictionary<string, SteamAppDetailRootModel>>(cancellationToken: cancellationToken);

        return result ?? new Dictionary<string, SteamAppDetailRootModel>();
    }

    public async Task<string?> GetAppDetailsJsonAsync(
        List<string> ids,
        string? countryCode,
        string? language,
        List<string>? filters,
        CancellationToken cancellationToken = default)
    {
        return await StoreUrl
            .AppendPathSegments("api", "appdetails")
            .SetQueryParams(GetAppDetailQueryParams(ids, countryCode, language, filters))
            .GetStringAsync(cancellationToken: cancellationToken);
    }

    public async Task<SteamAppListRootModel?> GetAppListAsync(CancellationToken cancellationToken)
    {
        return await ApiUrl
            .AppendPathSegments("ISteamApps", "GetAppList", "v0002")
            .SetQueryParams(new { key = this.steamKey, format = "json" })
            .GetJsonAsync<SteamAppListRootModel>(cancellationToken: cancellationToken);
    }

    public async Task<string?> GetAppListJsonAsync(CancellationToken cancellationToken)
    {
        return await ApiUrl
            .AppendPathSegments("ISteamApps", "GetAppList", "v0002")
            .SetQueryParams(new { key = this.steamKey, format = "json" })
            .GetStringAsync(cancellationToken: cancellationToken);
    }

    private static object GetAppDetailQueryParams(
        List<string> ids,
        string? countryCode,
        string? language,
        List<string>? filters)
    {
        if (countryCode is null)
        {
            if (language is null)
            {
                if (filters is null || filters.Count == 0)
                {
                    return new
                    {
                        appids = string.Join(",", ids)
                    };
                }

                return new
                {
                    appids = string.Join(",", ids),
                    filters = string.Join(",", filters)
                };
            }

            if (filters is null || filters.Count == 0)
            {
                return new
                {
                    appids = string.Join(",", ids),
                    l = language
                };
            }

            return new
            {
                appids = string.Join(",", ids),
                l = language,
                filters = string.Join(",", filters)
            };
        }

        if (language is null)
        {
            if (filters is null || filters.Count == 0)
            {
                return new
                {
                    appids = string.Join(",", ids),
                    cc = countryCode
                };
            }

            return new
            {
                appids = string.Join(",", ids),
                cc = countryCode,
                filters = string.Join(",", filters)
            };
        }

        if (filters is null || filters.Count == 0)
        {
            return new
            {
                appids = string.Join(",", ids),
                cc = countryCode,
                l = language
            };
        }

        return new
        {
            appids = string.Join(",", ids),
            cc = countryCode,
            l = language,
            filters = string.Join(",", filters)
        };
    }
}