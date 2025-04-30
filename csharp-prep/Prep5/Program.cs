using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name,squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInputNumber = Console.ReadLine();
        int userNumber = int.Parse(userInputNumber);
        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}

/*
Assignment Instructions
For this assignment, write a C# program that has several simple functions:

    - DisplayWelcome - Displays the message, "Welcome to the Program!"
    - PromptUserName - Asks for and returns the user's name (as a string)
    - PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    - SquareNumber - Accepts an integer as a parameter and returns that number squared 
        (as an integer)
    - DisplayResult - Accepts the user's name and the squared number and displays them.
    - Your Main function should then call each of these functions saving the return 
        values and passing data to them as necessary.

Sample output of the program could look as follows:

    Welcome to the program!
    Please enter your name: Brother Burton
    Please enter your favorite number: 42
    Brother Burton, the square of your number is 1764
*/