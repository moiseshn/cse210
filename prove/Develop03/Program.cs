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

