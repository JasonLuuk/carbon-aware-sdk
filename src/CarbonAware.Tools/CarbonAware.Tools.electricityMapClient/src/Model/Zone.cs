﻿using System.Text.Json.Serialization;

namespace CarbonAware.Tools.electricityMapClient.Model;

/// <summary>
/// The details of the zone serving a particular location.
/// </summary>
[Serializable]
public record Zone
{
    /// <summary>
    /// Unique countryCode for the region. such as AUS-NSW
    /// </summary>
    [JsonPropertyName("countryCode")]
    public string countryCode { get; set; } = string.Empty;

    /// <summary>
    /// countryName such as Australia
    /// </summary>
    [JsonPropertyName("countryName")]
    public string? countryName { get; set; } = string.Empty;

    /// <summary>
    /// zoneName such as New South Wales
    /// </summary>
    [JsonPropertyName("zoneName")]
    public string zoneName { get; set; } = string.Empty;

}
