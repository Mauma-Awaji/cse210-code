using System;

class Program
{
    static void Main(string[] args)

    // Aided by ChatGPT
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbersList = new();
        int number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbersList.Add(number);
        }
        numbersList.RemoveAt(numbersList.Count-1);
        Console.WriteLine($"The sum is: {numbersList.Sum()}");
        Console.WriteLine($"The average is: {numbersList.Average()}");
                // Finding the smallest positive number
        int? smallestPositive = null;
        foreach (int num in numbersList)
        {
            if (num > 0 && (smallestPositive == null || num < smallestPositive))
            {
                smallestPositive = num;
            }
        }
        Console.WriteLine($"The largest number positive is: {smallestPositive}");
        numbersList.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbersList)
        {
            Console.WriteLine(num);
        }

    }
}