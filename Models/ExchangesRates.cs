using System.Text.Json.Serialization;

namespace Blazor_API_Task;

public class ExchangesRates
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("timestamp")]
    public int Timestamp { get; set; }

    [JsonPropertyName("base")]
    public string BaseCurrency { get; set; } // Renamed from 'Base' to 'BaseCurrency'

    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("rates")]
    public Dictionary<string, double> Rates { get; set; } = new();
    //Using a Dictionary<string, double> is more flexible.
    //Instead of manually defining USD, EUR, GBP, etc., you can just loop through Rates dynamically.
    //This ensures your model works even if the API adds or removes currencies.
}
