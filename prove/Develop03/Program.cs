using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        // User presses "Enter" key until AllHidden or types "quit"
        // Extra: Load file, select reference from list, add "menu" option.
        while (quit == false)
        {
            Reference r1 = new Reference("John", 3, 16);
            string ref1 = r1.GetReferenceText();

            string text1 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            Scripture s1 = new Scripture(ref1, text1);
            Console.WriteLine($"{s1.GetRenderedText()}");

            // bool isHidden = true;
            // Word w1 = new Word(text1,isHidden);
            Console.ReadLine();
            Console.Clear();
        }
        
    }
}