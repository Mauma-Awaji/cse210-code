using System.Reflection.Metadata;

public class EternalGoal : Goal
{
    private int _noOfTimesCompleted = 0;
    public EternalGoal(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points)
    {
    }

    public void SetNoOfTimesCompleted(int number)
    {
        _noOfTimesCompleted = number;
    }
    public override string Serialize()
    {
        string result = "EternalGoal";
        result += "|";
        result += _goalName;
        result += "|";
        result += _goalDescription;
        result += "|";
        result += _points;
        result += "|";
        result += _noOfTimesCompleted;

        return result;
    }


    public override void TaskIsComplete()
    {
        _noOfTimesCompleted +=1;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_mark}] {_goalName} ({_goalDescription}) -- {_points}pts Completed {_noOfTimesCompleted} times");
    }
}