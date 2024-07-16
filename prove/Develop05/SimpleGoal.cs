using System.Reflection.Metadata;

public class SimpleGoal : Goal
{   public SimpleGoal(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points)
    {
    }


    public override string Serialize()
    {
        string result = "SimpleGoal";
        result += "|";
        result += _goalName;
        result += "|";
        result += _goalDescription;
        result += "|";
        result += _points;
        result += "|";
        result += _isComplete;

        return result;
    }


    public override void TaskIsComplete()
    {
        _isComplete = true;
        _mark = "X";
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_mark}] {_goalName} ({_goalDescription}) -- {_points}pts");
    }
}