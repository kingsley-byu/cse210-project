using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // define 3 scripture that the user can choose from by creating a list
        List<Scripture> scriptureLibrary = new List<Scripture>()
        {
           new Scripture(new Reference("1 Nephi",3,7),"And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
           new Scripture(new Reference("Ether", 12,27), "My grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."),
           new Scripture(new Reference("Mosiah", 18,9), "Stand as witnesses of God at all times and in all things, and in all places.")
   
        };
        
        // Let user choose a scripture
        Console.WriteLine("Choose a scripture to memorize:");
        Console.WriteLine("1. 1 Nephi 3:7");
        Console.WriteLine("2. Ether 12:27");
        Console.WriteLine("3. Mosiah 18:9");

        Console.Write("Enter 1, 2, or 3: ");
        string input = Console.ReadLine();
        // the condition allow user to select one of three by displaying the the library of scripture list to
        int choice = (input == "1" || input == "2" || input == "3") ? int.Parse(input) : 1;

        Scripture scripture = scriptureLibrary[choice - 1];

        Random random = new Random();
        while (true)
        {   
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Press Enter to reset the scripture.");
                Console.ReadLine();
                // The call to showAllWord show all text after all have been hidden and start the loop again by displaying the text.
                scripture.ShowAllWords();
                continue;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to quit:");
            string response = Console.ReadLine();

            if (response.ToLower() == "quit")
            {
                break;
            }
            int wordsToHide = random.Next(1,4);
            scripture.HideRandomWords(wordsToHide);
            
        }
    }
}