using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppDetailRootModel
{
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    [JsonPropertyName("data")]
    public SteamAppDetailDataModel? Data { get; set; }
}