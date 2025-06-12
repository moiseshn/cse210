using System;

public class Menu
{
    public void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Please select one of the following: ");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("\nSelect a choice from the menu: ");
    }
}
