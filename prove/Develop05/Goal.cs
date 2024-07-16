public abstract class Goal
{
    protected int _totalScore; // is this necessary? I don't think so but oh well

    protected string _goalDescription;
    protected string _goalName;
    protected int _points;
    protected bool _isComplete = false;
    protected string _mark = " ";
    public Goal(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public virtual int GetPoints()
    {
        if (IsComplete() == true)
        {
            return 0;
        }
        else
        {
            return _points;
        }

    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public abstract void TaskIsComplete();

    public abstract void DisplayGoal();

    public abstract string Serialize();

    public static Goal DeSerialize(string stringGoal)
    {
        Goal result;
        if (stringGoal.Substring(0,10) == "SimpleGoal")
        {
            string[] parts = stringGoal.Split("|");
            // Create new simple goal using the parts as the constructor variables
            result = new SimpleGoal(parts[1],parts[2], int.Parse(parts[3]));
            if (parts[4].ToLower() == "true")
            {
                result.TaskIsComplete();
            }

            return result;
        }
        else if (stringGoal.Substring(0,11) == "EternalGoal")
        {
            string[] parts = stringGoal.Split("|");
            // Create new eternal goal using the parts as the constructor variables
            EternalGoal eternal = new(parts[1],parts[2], int.Parse(parts[3]));
            eternal.SetNoOfTimesCompleted(int.Parse(parts[4]));
            result = eternal;
            return result;
        }
        else if (stringGoal.Substring(0,13) == "ChecklistGoal")
        {
            string[] parts = stringGoal.Split("|");
            // Create new checklist goal using the parts as the constructor variables
            ChecklistGoal checklist = new(parts[1],parts[2], int.Parse(parts[5]),int.Parse(parts[3]), int.Parse(parts[4]));
            checklist.SetNoOfTimesDone(int.Parse(parts[6]));
            if (int.Parse(parts[6]) == int.Parse(parts[5])) //part[5] is checklist no.
            {
                checklist._isComplete = true;
                checklist._mark = "X";
            }
            result = checklist;
            return result;
        }
        else
        {
            return null;
        }
    
    }

  
}