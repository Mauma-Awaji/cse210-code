using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        string play = "yes";
        while (play.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int mag_num = randomGenerator.Next(1, 101); 
            int guess_num = -2000;
            int count = 0;
            while (guess_num != mag_num)
            {
                count += 1;
                Console.Write("What is your guess? ");
                guess_num = int.Parse(Console.ReadLine());
                if (guess_num == mag_num)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (guess_num < mag_num)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            }
            Console.WriteLine($"It took {count} guesses");
            Console.Write("Would you like to play again? ");
            play = Console.ReadLine();
        }
    }
}