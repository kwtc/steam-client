﻿using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppFullGameModel
{
    [JsonPropertyName("appid")]
    public string? AppId { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}