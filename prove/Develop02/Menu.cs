using System.Collections.Generic;

public class Menu
{
    // Variable to add menu options from Main() and keep this Claas as a generic template.
    public List<string> _options = new List<string>();
    // Method to be called and display the Menu options from the List above.
    public void ShowMenu()
    {
        Console.WriteLine("\nPlease select one of the following: ");
        foreach (string option in _options)
        {
            Console.WriteLine(option);
        }
    }
}
