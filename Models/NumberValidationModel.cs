using Blazor_API_Task.Models;

namespace Blazor_API_Task.Models
{
    public class NumberValidationData // 'Data' from API => NumVerify
    {
        public bool valid {get; set;}
        public string? number {get; set;}
        public string? local_format {get; set;}
        public string? international_format {get; set;}
        public string? country_prefix {get; set;}
        public string? country_code {get; set;}
        public string? country_name {get; set;}
        // public string? location {get; set;}
        public string? carrier {get; set;}
        public string? line_type {get; set;}
    } 

}

public class NumberModelFavorite
{
    public NumberValidationData _NumberModel {get; set;}
    public bool _IsFavorite {get; set;}
}

/// <summary>
/// Testing Code
/// </summary>
public static class MockData
{
    public static NumberValidationData GetMockNumberValidationData()
    {
        return new NumberValidationData
        {
            valid = true,
            number = "1234567890",
            local_format = "123-456-7890",
            international_format = "+1 123-456-7890",
            country_prefix = "+1",
            country_code = "US",
            country_name = "United States",
            carrier = "AT&T",
            line_type = "mobile"
        };
    }
}
