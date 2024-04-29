using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("Whats is your first name? ");
        string firstname = Console.ReadLine();
        Console.Write("Whats is your last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");

    }
}