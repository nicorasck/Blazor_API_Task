namespace Blazor_API_Task;

public class Exchangesrates
{
    public bool Success {get; set;}
    public int Timestamp {get; set;}
    public string Base {get; set;}
    public string Date {get; set;} //in the example on https://exchangeratesapi.io/ it says that Date should be in the type string.
    public Dictionary<string, decimal> Rates {get; set;}

    /*
        This solution is common when it comes to API where you need the 'same' format on the variables.
    [JsonPropertyName("rates")] {get; set;}

        And then you can create a separate class with rates.
    */
}