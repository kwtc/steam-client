using System.Collections.Generic;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppContentDescriptorsModel
{
    public IEnumerable<int>? Ids { get; set; }
    public string? Notes { get; set; }
}