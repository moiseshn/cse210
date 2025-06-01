using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

/*
************** LESSONS LEARNED ***********************************
1. Separated Load and Save Classes from Entry.cs to their own file.
2. Changed Classes from void to List. Error "void to string" when assinging a variable.
3. Using a bool for quitting the program and nest a second IF statement for Menu inputs.
4. Saving the generated prompt by changing from void to string the method.
5. Added a Try Catch to handle string format exceptions.
6. Added a Method to get the user's IP Address. Extra #2

****************** PENDING ***************************************
- Saving with delimeter in csv formating. Extra #3
*/

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to your Journal App!");        
        
        // Object creation
        Menu myMenu = new Menu();
        Prompt myPrompts = new Prompt();
        Entry myEntries = new Entry(); // myEntries._entries is the list name.
        Load myLoads = new Load();
        Save mySaves = new Save();
        
        // Global variables to be used in While Loop Menu & IF Statements
        //int optionNumber = 1; *** Not used anymore in this scope.
        string pickedPrompt; // Not saving generated prompt ************
        string userAnswer;
        
        // Display Menu recurrently based on IF statements
        // while (optionNumber >= 1 && optionNumber <=4) *** breaks the loop if errors
        try
        {
            bool quit = false;
            while (quit == false)
            {
                myMenu.ShowMenu();
                string userInput = Console.ReadLine();
                int optionNumber = int.Parse(userInput);

                
                if (optionNumber >= 1 && optionNumber <=5)
                {
                    if (optionNumber == 1) // Prompt and Entry
                    {
                        // Calls the Prompt Generator and saves the result in pickedPrompt
                        pickedPrompt = myPrompts.RandomPrompt(myPrompts._prompts); // Changed Method to string to save it.
                        Console.WriteLine(pickedPrompt);
                        // Indicator for the user to write something
                        Console.Write("> ");
                        // Save the user input in a variable
                        userAnswer = Console.ReadLine();
                        // Generates and saves the Date of the entry
                        // DateTime theCurrentTime = DateTime.Now;
                        // string dateText = theCurrentTime.ToShortDateString();

                        // Store IP Addresses
                        string myIp = myEntries.GetIPAddress();
                        // Stores the date, prompt and answer
                        myEntries._entries.Add($"Date: {dateText}, Prompt: {pickedPrompt}, Entry: {userAnswer}, IP Address: {myIp}");
                    }
                    else if (optionNumber == 2) // Display
                    {
                        Console.WriteLine($"\nYour entries are: ");
                        myEntries.DisplayEntries();
                    }
                    else if (optionNumber == 3) // Load
                    {
                        // Asks the user to type the name of the file to be retrieved.
                        Console.WriteLine("\nType your filename to load: ");
                        string userFileToLoad = Console.ReadLine();
                        // Saves the filename to a variable to pass it as a parameter.
                        List<string> pastEntries = myLoads.ReadFromFile(userFileToLoad);
                        // Display the entries of the loaded file
                        Console.WriteLine(pastEntries);
                    }
                    else if (optionNumber == 4) // Save
                    {
                        // Asks the user to type the name of the file to be saved with.
                        Console.WriteLine("\nType the filename to save: ");
                        // Saves the filename to a variable to pass it as a parameter.
                        string userFileToSave = Console.ReadLine();
                        // Calls the method with two parameters: filename, entries.
                        mySaves.SaveToFile(userFileToSave, myEntries._entries);
                    }
                    else
                    {
                        Console.WriteLine("\nCan't wait to see your next entry!\n");
                        quit = true;
                    }
                }
                else
                {
                    Console.WriteLine("\nSorry, that's not an option."); // Exception if input is a string. *******
                    quit = false;
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("\nFormat Exception. Only whole numbers are allowed.");

        }
    }
}

/*
Review the Program Specification
Refer to the Journal program specification. As a team, review the 
program requirements and how it is supposed to work.

What does the program do? Provides the user with ideas to write about.
What user inputs does it have? Register and View. 
What output does it produce? Lists
How does the program end? A specified number.

Program Specification
For this assignment you will write a program to help people record the 
events of their day by supplying prompts and then saving their responses 
along with the question and the date to a file.

Functional Requirements
This program must contain the following features:

1. Write a new entry - Show the user a random prompt (from a list that 
    you create), and save their response, the prompt, and the date as 
    an Entry.
2. Display the journal - Iterate through all entries in the journal and 
    display them to the screen.
3. Save the journal to a file - Prompt the user for a filename and then 
    save the current journal (the complete list of entries) to that 
    file location.
4. Load the journal from a file - Prompt the user for a filename and 
    then load the journal (a complete list of entries) from that file. 
    This should replace any entries currently stored in the journal.
5. Provide a menu that allows the user choose these options
6. Your list of prompts must contain at least five different prompts. 
    Make sure to add your own prompts to the list, but the following 
    are examples to help get you started:
    - Who was the most interesting person I interacted with today?
    - What was the best part of my day?
    - How did I see the hand of the Lord in my life today?
    - What was the strongest emotion I felt today?
    - If I had one thing I could do over today, what would it be?
7. Your interface should generally follow the pattern shown in the 
    video demo below.

Design Requirements
In addition, your program must:
1. Contain classes for the major components in the program.
2. Contain at least two classes in addition to the Program class.
3. Demonstrate the principle of abstraction by using member variables 
    and methods appropriately.

Simplifications
For the core requirements you do not need to worry about the following:

- Saving your file as a .csv file requires you to handle commas and quotes 
    in the content appropriately. At this point, you can ignore that and 
    just choose a symbol for a separator that you think is unlikely to 
    show up in the content (such as | or ~ or ~|~).
- You do not need to store the date as an actual C# DateTime object in your 
    class or in the file. You can simply store it as a string.

Showing Creativity and Exceeding Requirements
Meeting the core requirements makes your program eligible to receive a 
93%. To receive 100% on the assignment, you need to show creativity and 
exceed these requirements.

Here are some ideas you might consider:
- Think of other problems that keep people from writing in their 
    journal and address one of those.
- Save other information in the journal entry. <<<<<<<< Computer System or GPS location ????????????????????
- Improve the process of saving and loading to save as a .csv file that ****** Work in progress ***********
    could be opened in Excel (make sure to account for quotation marks 
    and commas correctly in your content.
- Save or load your document to a database or use a different library 
    or format such as JSON for storage.
- Report on what you have done to exceed requirements by adding a 
    description of it in a comment in the Program.cs file.
*/