namespace Blazor_API_Task.Service;

public class NumberValidationApiService
{
    private readonly string _apiKey;
    public NumberValidationApiService(string NumberValidationApiKey)
    {
        _apiKey = NumberValidationApiKey;
    }
    public string GetApiKey()
    {
        return _apiKey;
    }
}

