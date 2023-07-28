using System.Threading;
using System.Threading.Tasks;
using Kwtc.Steam.Client.Models.Details;
using Kwtc.Steam.Client.Models.List;

namespace Kwtc.Steam.Client;

public interface ISteamClient
{
    Task<SteamAppDetailRootModel?> GetAppDetailsAsync(string id, CancellationToken cancellationToken = default);

    Task<SteamAppListRootModel?> GetAppListAsync(CancellationToken cancellationToken = default);

    Task<string?> GetAppListJsonAsync(CancellationToken cancellationToken = default);
}