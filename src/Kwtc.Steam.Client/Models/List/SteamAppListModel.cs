using System.Collections.Generic;

namespace Kwtc.Steam.Client.Models.List;

public class SteamAppListModel
{
    public IEnumerable<SteamAppModel>? Apps { get; set; }
}