using System.Collections.Generic;

public class Menu
{
    /*
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
    */
    public void ShowMenu()
    {
        Console.WriteLine("\nPlease select one of the following: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("\nEnter the number of your choice: ");
    }
}
