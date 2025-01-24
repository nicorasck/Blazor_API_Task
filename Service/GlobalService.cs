using Blazor_API_Task.Models;

public class GlobalService
{
    public List<NumberValidationData> savedNumbers = new List<NumberValidationData>();
    public void AddNumber(NumberValidationData numberValidationData)
    {
        savedNumbers.Add(numberValidationData);
    
    }
}