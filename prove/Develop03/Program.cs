using System;
// Aided By AI and Jada Bower

class Program
{
    static void Main(string[] args)
    {        
        Console.Clear();
        Console.WriteLine("Welcome to The Scripture Memorizer!\n");

        // Set the chapter and verse using Reference
        string chap = "Ether 12";
        int ver = 6;        
        Reference r = new(chap, ver);

        // Set the words for the scripture
        List<string> list = ["And", "now,", "I,", "Moroni,", "would", "speak", "somewhat", "concerning",
         "these", "things;", "I", "would", "show", "unto", "the", "world", "that", "faith", "is", "things", 
         "which", "are", "hoped", "for", "and", "not", "seen;", "wherefore,", "dispute", "not", "because", 
         "ye", "see", "not,", "for", "ye", "receive", "no", "witness", "until", "after", "the", "trial", 
         "of", "your", "faith."];

        Scripture scrip = new(); 
        for (int i = 0; i < list.Count; i++)
        {
            Word word = new();
            word.SetWord(list[i]);
            scrip.SetWords(word);
        }
        scrip.SetRef(r); // Attaches the reference to the scripture
        scrip.DisplayScripture();

        Console.WriteLine("Press enter to hide words or type 'quit' to exit the program");
        string input = Console.ReadLine().ToLower();

        while (input != "quit" || scrip.GetCompletelyHidden() == false)
        {
            Console.Clear();
            scrip.HideThreeRanWords();
            if (scrip.GetCompletelyHidden() == true)
            {
                Console.WriteLine("All words have been hidden. Type 'quit' to exit the program");
            }
            else
            {
                Console.WriteLine("Press enter to hide words or type 'quit' to exit the program");
            }

            input = Console.ReadLine().ToLower();

        } 

    
    }
    
}