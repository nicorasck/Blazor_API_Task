
using Blazor_API_Task.Models;

// public class GlobalService
// {
//     public List<NumberValidationData> SavedNumbers = new List<NumberValidationData>();
//     public void AddNumber(NumberValidationData numberValidationData)
//     {
//         // If there are any duplicates using the method .Any()
//         if (!SavedNumbers.Any(n => n.number == numberValidationData.number))
//         {
//             SavedNumbers.Add(numberValidationData);
//         }
//     }
// }


#region Code for GetMockNumberValidationData
//this code will not look for any duplicates and therefore the existing instance in
//GetMockNumberValidationData() till display multiple times when entering a number!
public class GlobalService
{
    public List<NumberValidationData> SavedNumbers { get; private set; } = new();

    public void AddNumber(NumberValidationData number)
    {
        Console.WriteLine($"Adding number to GlobalService: {number.number}");
        SavedNumbers.Add(number);
    }
}
#endregion


public class NumberService
{
    List<NumberModelFavorite> ListOfFavorites = new List<NumberModelFavorite>();

    public List<NumberModelFavorite> AddFavoriteNumber(NumberModelFavorite number)
    {
        ListOfFavorites.Add(number);
        return ListOfFavorites;
    }

    public List<NumberModelFavorite> RemoveFavoriteNumber(NumberModelFavorite number)
    {
        ListOfFavorites.Remove(number);
        return ListOfFavorites;
    }
}
