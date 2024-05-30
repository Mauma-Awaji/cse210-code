using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!\n");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number =  int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int num)
        {
            int square = num * num;
            return square;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}\n");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int square = SquareNumber(PromptUserNumber());
        DisplayResult(name, square);             
    }
}