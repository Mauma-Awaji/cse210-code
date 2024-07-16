using System.Reflection.Metadata;

public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _checklistNumber;
    private int _noOfTimesDone = 0;
    public ChecklistGoal(string goalName, string goalDescription, int checklistNumber, int points, int bonusPoints) : base(goalName, goalDescription, points)
    {
        _checklistNumber = checklistNumber;
        _bonusPoints = bonusPoints;
    }

    public void SetNoOfTimesDone(int number) // Setter for NoOfTimesDone for testing purposes
    {
        _noOfTimesDone = number;
    }

    public void SetChecklistNumber(int number)
    {
        _checklistNumber = number;
    }
    public override string Serialize()
    {
        string result = "ChecklistGoal";
        result += "|";
        result += _goalName;
        result += "|";
        result += _goalDescription;
        result += "|";
        result += _points;
        result += "|";
        result += _bonusPoints;
        result += "|";
        result += _checklistNumber;
        result += "|";
        result += _noOfTimesDone;

        return result;
    }

    public override void TaskIsComplete()
    {
        _noOfTimesDone += 1;
        if (_noOfTimesDone >= _checklistNumber)
        {
            _isComplete = true;
            _mark = "X";

        }       
    }

    public override int GetPoints()
    {
        if (_noOfTimesDone < _checklistNumber-1)
        {
            return _points;
        }
        else if (_noOfTimesDone == _checklistNumber-1)
        {
            return _points + _bonusPoints;
        }
        else
        {
            return 0;
        }
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_mark}] {_goalName} ({_goalDescription}) -- {_points}pts -- Currently completed {_noOfTimesDone}/{_checklistNumber}");
    }

}