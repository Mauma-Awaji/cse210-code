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
        Console.WriteLine("Hello Develop05 World!");



        // Test stuff
        SimpleGoal simple = new("Talk", "give a talk", 50);


        EternalGoal eternal = new("Scriptures", "read scripture for 10mins", 50);

        ChecklistGoal checklist = new("Temple", "visit the temple 3 times", 3, 50, 150);
        _goals.Add(simple);
        _goals.Add(eternal);
        _goals.Add(checklist);
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetGoalName()); 
            goal.DisplayGoal();
            _score.UpdateScore(goal.GetPoints());
            goal.TaskIsComplete();
            goal.DisplayGoal();
            _score.ShowScore();

        }
        Program.SaveFile();

        Program.LoadFile();

        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetGoalName()); 
            goal.DisplayGoal();
            _score.UpdateScore(goal.GetPoints());
            goal.TaskIsComplete();
            goal.DisplayGoal();
            _score.ShowScore();

        }

        Console.WriteLine();
    }
}