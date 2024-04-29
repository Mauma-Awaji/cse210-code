using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage(Just put in the number): ");
        string gradeString = Console.ReadLine();
        int gradeInt = int.Parse(gradeString);
        string gradeLetter = "";
        string gradeSign = "";

        if (gradeInt >= 90) 
        { 
            gradeLetter = "A";
        }
 
        else if (gradeInt >= 80) 
        { 
            gradeLetter = "B";
        }  
        else if (gradeInt >= 70) 
        { 
            gradeLetter = "C";
        }
        else if (gradeInt >= 60) 
        { 
            gradeLetter = "D";
        }
        else
        { 
            gradeLetter = "F";
        }

        if (gradeInt % 10 >= 7 && !(gradeLetter == "A" || gradeLetter == "F"))
        {
            gradeSign = "+";
        } 
        else if (gradeInt % 10 < 3 && !(gradeLetter == "A" || gradeLetter == "F"))
        {
            gradeSign = "-";
        }

        Console.WriteLine($"Your grade is {gradeLetter}{gradeSign}.");

        if (gradeInt >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("I'm sorry. Your grade isn't high enough to pass this class. Try again. I know you can do it!");
        }
    }
}