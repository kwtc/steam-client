using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Kwtc.Steam.Client.Tests;

/// <summary>
/// These tests are dependent on the Steam API being available and responding as expected.
/// </summary>
public class SteamClientTests
{
    private const string ValidSteamProductIdOne = "70"; // Half Life
    private const string ValidSteamProductIdTwo = "220"; // Half Life 2

    [Fact]
    public async Task SteamClient_ValidProductIdNoCountryCodeAndPriceFilter_ShouldReturnProductPriceDetails()
    {
        var sut = GetSut(GetOptions("STEAMKEY"));

        // Steams public API is limited so to avoid IP timeout we sleep a bit :D 
        Thread.Sleep(2005);

        var result = await sut.GetAppDetailsAsync(
            [ValidSteamProductIdOne],
            null,
            "english",
            null,
            CancellationToken.None);

        result[ValidSteamProductIdOne].Data.Should().NotBeNull();
    }
    
    [Fact]
    public async Task SteamClient_ValidProductIdsAndPriceFilter_ShouldReturnProductPriceDetailsForBothProducts()
    {
        var sut = GetSut(GetOptions("STEAMKEY"));

        // Steams public API is limited so to avoid IP timeout we sleep a bit :D 
        Thread.Sleep(2005);

        var result = await sut.GetAppDetailsAsync(
            [ValidSteamProductIdOne, ValidSteamProductIdTwo],
            null,
            "english",
            [SteamFilters.PriceOverview],
            CancellationToken.None);

        result[ValidSteamProductIdOne].Data?.PriceOverview.Should().NotBeNull();
        result[ValidSteamProductIdOne].Data?.Developers.Should().BeNull();
        result[ValidSteamProductIdTwo].Data?.PriceOverview.Should().NotBeNull();
        result[ValidSteamProductIdTwo].Data?.Developers.Should().BeNull();
    }

    [Theory]
    [InlineData("ar", "USD")]
    [InlineData("bg", "EUR")]
    [InlineData("zh-CN", "EUR")]
    [InlineData("zh-TW", "EUR")]
    [InlineData("cs", "USD")]
    [InlineData("da", "USD")]
    [InlineData("nl", "EUR")]
    [InlineData("en", "USD")]
    [InlineData("fi", "EUR")]
    [InlineData("fr", "EUR")]
    [InlineData("de", "EUR")]
    [InlineData("el", "USD")]
    [InlineData("hu", "EUR")]
    [InlineData("it", "EUR")]
    [InlineData("ja", "USD")]
    [InlineData("ko", "USD")]
    [InlineData("no", "NOK")]
    [InlineData("pl", "PLN")]
    [InlineData("pt-BR", "EUR")]
    [InlineData("pt", "EUR")]
    [InlineData("ro", "EUR")]
    [InlineData("ru", "RUB")]
    [InlineData("es-419", "EUR")]
    [InlineData("es", "EUR")]
    [InlineData("sv", "USD")]
    [InlineData("th", "THB")]
    [InlineData("tr", "USD")]
    [InlineData("uk", "GBP")]
    [InlineData("vn", "VND")]
    public async Task SteamClient_ValidProductIdWithCountryCode_ShouldReturnProductDetailsWithCorrectCurrency(
        string countryCode,
        string currency)
    {
        var sut = GetSut(GetOptions("STEAMKEY"));

        // Steams public API is limited so to avoid IP timeout we sleep a bit :D 
        Thread.Sleep(2005);

        var result = await sut.GetAppDetailsAsync(
            [ValidSteamProductIdOne],
            countryCode,
            "english",
            null,
            CancellationToken.None);

        result.Should().NotBeNull();
        result[ValidSteamProductIdOne].Data?.PriceOverview?.Currency.Should().Be(currency);
    }

    private static SteamClient GetSut(IOptions<SteamConfig> config)
    {
        return new SteamClient(config);
    }

    private static IOptions<SteamConfig> GetOptions(string? steamApiKey)
    {
        var settings = new Dictionary<string, string>
        {
            { "SteamConfig:ApiKey", steamApiKey ?? "" }
        };

        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(settings!)
            .Build();

        var config = new SteamConfig { ApiKey = "" };

        configuration.GetSection("SteamConfig").Bind(config);

        return Options.Create(config);
    }
}