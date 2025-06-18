using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        string userInput;
        // Extra: Load file, select reference from list, add "menu" option.
        do
        {
            Reference r1 = new Reference("John", 3, 16);
            string ref1 = r1.GetReferenceText();

            string text1 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

            Word w1 = new Word(text1);
            string wordList = w1.GetRenderedText();
            w1.ShowWord(text1);
            
            Scripture s1 = new Scripture(ref1, text1);
            Console.WriteLine(s1.GetRenderedScripture());

            // bool isHidden = true;

            Console.WriteLine("\nPress \"Enter\" to continue or type \"quit\" to finish: ");
            userInput = Console.ReadLine();
            
            quit = false;
        } while (!(quit == false || userInput == "quit"));
    }
}

/*
The program can end in one of two ways: 
- Either the user types quit, or 
- all of the words in the scripture have been hidden.

Demo Video:
https://video.byui.edu/media/t/1_fmkzempr

Specification
Functional requirements
Your program must do the following:

1. Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
2. Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
3. Clear the console screen and display the complete scripture, including the reference and the text.
4. Prompt the user to press the enter key or type quit.
5. If the user types quit, the program should end.
6. If the user presses the enter key (without typing quit), the program should hide a few random words in the 
    scripture, clear the console screen, and display the scripture again.
7. The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
8. When all words in the scripture are hidden, the program should end.
9. When selecting the random words to hide, for the core requirements, you can select any word at random, 
    even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words 
    that are not already hidden.)

Design Requirements
In addition your program must:

1. Use the principles of Encapsulation, including proper use of classes, methods, public/private access modifiers, 
    and follow good style throughout.
2. Contain at least 3 classes in addition to the Program class: one for the scripture itself, one for the reference 
    (for example "John 3:16"), and to represent a word in the scripture.
3. Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range 
    ("Proverbs 3:5" or "Proverbs 3:5-6").

Showing Creativity and Exceeding Requirements
Meeting the core requirements makes your program eligible to receive a 93%. To receive 100% on the assignment, you 
need to show creativity and exceed these requirements.

Here are some ideas you might consider:

1. Think of other challenges that people find when trying to memorize a scripture. Find a way to have your program 
    help with these challenges.
2. Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present 
    to the user.
3. Have the program to load scriptures from a files.

*/
