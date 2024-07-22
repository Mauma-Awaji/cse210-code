using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{    
    static Score _score = new();
    static string _fileName;
    static List<Goal> _goals =new();
    public static void SaveFile() // Save goals to file I think
    {
        Console.Write("What file would you like to save this to?\n >");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new(_fileName))
        {
            outputFile.WriteLine(_score.GetScore());
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.Serialize());
            }

        }
        Console.WriteLine("Goal saved to file");
    }
    public static void LoadFile()
    {
        _goals = new();
        Console.Write("Select file to load\n  > ");
        _fileName = Console.ReadLine();
        string [] lines = System.IO.File.ReadAllLines(_fileName);
        bool firstLine = true;
        foreach (string line in lines)
        {
            if (firstLine)
            {
                _score.SetScore(int.Parse(line));
                firstLine = false;
            }
            else
            {
                _goals.Add(Goal.DeSerialize(line));
            }

        }

    } 
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");



        // // Test stuff
        // SimpleGoal simple = new("Talk", "give a talk", 50);


        // EternalGoal eternal = new("Scriptures", "read scripture for 10mins", 50);

        // ChecklistGoal checklist = new("Temple", "visit the temple 3 times", 3, 50, 150);
        // _goals.Add(simple);
        // _goals.Add(eternal);
        // _goals.Add(checklist);
        // foreach (Goal goal in _goals)
        // {
        //     Console.WriteLine(goal.GetGoalName()); 
        //     goal.DisplayGoal();
        //     _score.UpdateScore(goal.GetPoints());
        //     goal.TaskIsComplete();
        //     goal.DisplayGoal();
        //     _score.ShowScore();

        // }
        // Program.SaveFile();

        // Program.LoadFile();

        // foreach (Goal goal in _goals)
        // {
        //     Console.WriteLine(goal.GetGoalName()); 
        //     goal.DisplayGoal();
        //     _score.UpdateScore(goal.GetPoints());
        //     goal.TaskIsComplete();
        //     goal.DisplayGoal();
        //     _score.ShowScore();

        // }

        // Console.WriteLine();

        // Main Program Starts
        string option = "0";
        while (option != "6")
        {
            _score.ShowScore();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal\n  2. List Goals");
            Console.WriteLine("  3. Save Goals\n  4. Load Goals");
            Console.WriteLine("  5. Record Event\n  6. Quit");
        

            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            if (option == "1")
            {
                
           
                string goalType = "";
                while (goalType != "1" || goalType != "2" || goalType != "3")
                {
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? "); 
                    goalType = Console.ReadLine();
                    if (goalType == "1")
                    {
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());
                        SimpleGoal simple = new(goalName, goalDescription, points);
                        _goals.Add(simple);
                        break;
                    }
                    else if (goalType == "2")        
                    {
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());
                        EternalGoal eternal = new(goalName, goalDescription, points);
                        _goals.Add(eternal);
                        break;
                    }
                    else if (goalType == "3")
                    {   
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        int checklistNumber = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        ChecklistGoal checklist = new(goalName, goalDescription, checklistNumber, points, bonusPoints);  
                        _goals.Add(checklist);
                        break;                  
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry. You did not enter a valid option.");
                    }
                }
                
                            
            }
            else if (option == "2")
            {
                int count = 1;
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in _goals)
                {
                                            
                    Console.Write($"{count}. ");
                    goal.DisplayGoal();
                    count +=1;
                }
                Console.WriteLine();
            }
            else if (option == "3")
            {
                Program.SaveFile();
                Console.WriteLine();
            }
            else if (option == "4")
            {
                Program.LoadFile();
                Console.WriteLine();
            }
            else if (option == "5")
            {
                int count = 1;
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in _goals)                
                {
                    Console.WriteLine($"{count}. {goal.GetGoalName()}");
                    count += 1;
                }
                Console.Write("Which goal did you accomplish? ");
                int goalSelected = int.Parse(Console.ReadLine());
                _score.UpdateScore(_goals[goalSelected-1].GetPoints());
                _goals[goalSelected-1].TaskIsComplete();
                Console.WriteLine($"Congratulations! You now have {_score.GetScore()} points");
                Console.WriteLine();

            }
            else if (option == "6")
            {
                // Exit the program
            }
            else 
            {
                Console.WriteLine("\nI'm sorry. You did not enter a valid option.\n");
            }           
        }// bracket was here
    }
}