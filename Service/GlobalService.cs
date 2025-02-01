using Blazor_API_Task;
using Blazor_API_Task.Models;

// public class GlobalService
// {
//     public List<NumberValidationData> SavedNumbers = new List<NumberValidationData>();
//     public List<NumberValidationData> ListOfFavorites { get; set; } = new();

//     public void AddNumber(NumberValidationData numberValidationData)
//     {
//         // If there are any duplicates using the method .Any()
//         if (!SavedNumbers.Any(n => n.number == numberValidationData.number))
//         {
//             SavedNumbers.Add(numberValidationData);
//         }
//     }
//     public void AddFavoriteNumber(NumberValidationData number)
//     {
//         if (!ListOfFavorites.Contains(number))
//         {
//             ListOfFavorites.Add(number);
//         }
//     }

//     // Remove a number from favorites
//     public void RemoveFavoriteNumber(NumberValidationData number)
//     {
//         if (ListOfFavorites.Contains(number))
//         {
//             ListOfFavorites.Remove(number);
//         }
//     }

//     // Check if a number is a favorite
//     public bool IsFavorite(NumberValidationData number)
//     {
//         return ListOfFavorites.Contains(number);
//     }
// }


#region Code for GetMockNumberValidationData
//this code will not look for any duplicates and therefore the existing instance in
//GetMockNumberValidationData() till display multiple times when entering a number!
public class GlobalService
{
    public List<NumberValidationData> SavedNumbers { get; private set; } = new();
    public List<NumberValidationData> ListOfFavorites { get; private set; } = new();

    // Add a saved number to the list
    public void AddNumber(NumberValidationData number)
    {
        if (!SavedNumbers.Contains(number))
        {
            SavedNumbers.Add(number);
        }
    }
    public void AddFavoriteNumber(NumberValidationData number)
    {
        if (!ListOfFavorites.Contains(number))
        {
            ListOfFavorites.Add(number);
        }
    }
    // Remove a number from favorites
    public void RemoveFavoriteNumber(NumberValidationData number)
    {
        if (ListOfFavorites.Contains(number))
        {
            ListOfFavorites.Remove(number);
        }
    }
    // Check if a number is a favorite
    public bool IsFavorite(NumberValidationData number)
    {
        return ListOfFavorites.Contains(number);
    }
}
#endregion

public class ExchangeService
{   // To store rates fetched from the API
    public List<ExchangesRates> Currencies { get; set; } = new();
}
