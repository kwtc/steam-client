﻿using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Models.Details;

public class SteamAppIdDescriptionModel
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}