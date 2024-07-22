public class Score
{

    private int _totalScore = 0; // score for the goals

    public void UpdateScore(int score)
    {
        _totalScore += score;
    }

    public void SetScore(int score)
    {
        _totalScore = score;
    }
    public int GetScore()
    {
        return _totalScore;
    }

       public void ShowScore()
    {
        Console.WriteLine($"You have {_totalScore} points.");
    }
}