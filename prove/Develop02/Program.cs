using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {   
        // Create objects for Journal
        Journal journal = new();
        // Welcome statements and instructions for the user
        Console.WriteLine("Welcome to your journal!");
        
        // initialize while loop
        int option = 0;

        // while loop for all the options using the classes related to them
        while (option != 5) 
        {
            // Present the options to the user and receive input
            Console.WriteLine("");
            Console.WriteLine("What would you like to do? (Select the number for what you want)");
            Console.WriteLine("  1. Write");
            Console.WriteLine("  2. Load");
            Console.WriteLine("  3. Display");
            Console.WriteLine("  4. Save");
            Console.WriteLine("  5. Quit");
            Console.Write("  > ");
            string stringOption = Console.ReadLine();
            option = int.Parse(stringOption);
            Console.WriteLine("");

            if (option == 1)
            {
                // Create entry object
                Entry entry = new();
                // Picks prompt for user and collects respons
                entry.PromptForResponse();
                // Saves the entry to the journal's list
                journal.AddEntriesToList(entry);
            }
            else if (option == 2)
            {
                // Adds entries from the selected file to the journal's list
                journal.LoadEntries();
            }
            else if (option == 3)
            {   
                Console.WriteLine("Here are your entries\n");
                // Displays all the entries in the journal's list
                journal.ShowEntries();
            }
            else if(option == 4)
            {
                // Save the entries in the journal's list to the selected file
                // This currently overwrites all the entries in the selected file
                journal.SaveEntries();
            }
            else
            {
                // 5 should close the program.
                // Anything else should just have the program loop from the beginning
                // Anything that's not an integer will probably break the code and return an error.

            }
        }

        




        






    }

}
