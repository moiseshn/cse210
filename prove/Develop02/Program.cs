using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

///////////////////////// AGENDA ///////////////////////////
/*
1. Remind meeting's time, location and lead student.
2. Prayer by next week's lead student.
3. Before code review: Explain the parts that you have finished 
    and the parts that you are still working on.
4. Code review: 
    - Begin by showing parts of the program that are complete 
        (or nearly complete). Talk about what you were trying to 
        accomplish and why you selected the approach you did.
    - Others can share suggestions, ask questions and share screen.
    - Share parts of the program that are not complete yet, or 
        discuss areas that you have not worked on.
    - Others share potential solutions, ask questions, share screen.
5. Conclude: Set next week's lead student and submit participation.

************** LESSONS LEARNED ***********************************
1. Separated Load and Save Classes from Entry.cs to their own file.
2. Changed Classes from void to List. Error "void to string" when assinging a variable.
3. 

****************** PENDING ***************************************
1. Program quits if out of range number is entered. It should return to menu.
2. Prompt selected is not getting stored.
3. Saving with delimeter in csv formating.

*/

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to your Journal App!");

        // Feed Prompt list (new object)
        Prompt myPrompts = new Prompt();
        myPrompts._prompts.Add("Write about someone you interacted with today!");
        myPrompts._prompts.Add("Any challenge today to write about?");
        myPrompts._prompts.Add("What would you have done differently today?");
        myPrompts._prompts.Add("What was today's highlight?");
        myPrompts._prompts.Add("What could have been a spitual esence this day?");
        
        // Feed Menu list
        Menu myMenu = new Menu();
        myMenu._options.Add("1. Write");
        myMenu._options.Add("2. Display");
        myMenu._options.Add("3. Load");
        myMenu._options.Add("4. Save");
        myMenu._options.Add("5. Quit");

        // Entry list ready to feed in a final format.
        Entry myEntries = new Entry(); // myEntries._entries is the list name.

        // Save and Load classes
        Load myLoads = new Load();
        Save mySaves = new Save();
        
        // Global variables to be used in While Loop Menu & IF Statements
        int optionNumber = 1;
        string pickedPrompt = myPrompts._pickedPrompt;
        string userAnswer;
        
        // Display Menu recurrently based on IF statements
        while (optionNumber >= 1 && optionNumber <=4)
        {
            myMenu.ShowMenu();
            Console.Write("Enter the number of your choice: ");
            string userInput = Console.ReadLine();
            optionNumber = int.Parse(userInput);

            if (optionNumber == 1) // Prompt and Entry
            {
                // Calls the Prompt Generator and saves the result in pickedPrompt
                myPrompts.RandomPrompt(myPrompts._prompts); // It's not storing it to the entry **************
                // Indicator for the user to write something
                Console.Write("> ");
                // Save the user input in a variable
                userAnswer = Console.ReadLine();
                // Generates and saves the Date of the entry
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                // Stores the date, prompt and answer
                myEntries._entries.Add($"Date: {dateText}\nPrompt: {pickedPrompt}\nEntry: {userAnswer}\n");
            }
            else if (optionNumber == 2) // Display
            {
                Console.WriteLine($"Your entries are: ");
                myEntries.DisplayEntries();
            }
            else if (optionNumber == 3) // Load
            {
                // Asks the user to type the name of the file to be retrieved.
                Console.Write("Type your filename to load: ");
                string userFileToLoad = Console.ReadLine();
                // Saves the filename to a variable to pass it as a parameter.
                List<string> pastEntries = myLoads.ReadFromFile(userFileToLoad);
                // Display the entries of the loaded file
                foreach (string x in pastEntries)
                {
                    Console.WriteLine(x); // We could add the Save output formating for each part (video example) *****
                    // Console.WriteLine($"Date: {x.Date}\nPrompt: {x.Prompt}\nEntry: {x.Answer}");
                }
            }
            else if (optionNumber == 4) // Save
            {
                // Asks the user to type the name of the file to be saved with.
                Console.WriteLine("Type the filename to save: ");
                // Saves the filename to a variable to pass it as a parameter.
                string userFileToSave = Console.ReadLine();
                // Calls the method with two parameters: filename, entries.
                mySaves.SaveToFile(userFileToSave,myEntries._entries);
            }
            else if (optionNumber == 5) // Quit ****** else if >5 || <1 error, else by message **************
            {
                Console.WriteLine("Can't wait to see your next entry! \n");
            }
            else{
                Console.WriteLine("Sorry, that's not an option"); // program quits instead of showing the menu.
            }
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
- Save other information in the journal entry.
- Improve the process of saving and loading to save as a .csv file that 
    could be opened in Excel (make sure to account for quotation marks 
    and commas correctly in your content.
- Save or load your document to a database or use a different library 
    or format such as JSON for storage.
- Report on what you have done to exceed requirements by adding a 
    description of it in a comment in the Program.cs file.
*/