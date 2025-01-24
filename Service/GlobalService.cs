using Blazor_API_Task.Models;

public class GlobalService
{
    public List<NumberValidationData> savedNumbers = new List<NumberValidationData>();

    public void AddNumber(NumberValidationData numberValidationData)
    {
        // If there are any duplicates using the method .Any()
        if (!savedNumbers.Any(n => n.number == numberValidationData.number))
        {
            savedNumbers.Add(numberValidationData);
        }
    }
}
