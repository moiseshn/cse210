using System;

public class Menu
{
    // Methods
    public void ShowMainMenu()
    {
        Console.WriteLine("Menu options: ");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Events");
        Console.WriteLine("6. Quit");
        Console.Write("\nSelect a choice from the menu: ");
    }

    public void ShowGoalsMenu()
    {
        Console.WriteLine($"\nThe types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("\nWhich type of goal would you like to create? ");
    }
}