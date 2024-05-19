public class Prompt
{
    // Aided by ChatGPT
    //List of prompts
    public List<string> _prompts = new List<string>
    {
        "How have you seen the hand of the Lord in your life today?",
        "Did you get to try something new today?",
        "If you could change one thing that happened today what would it be?",
        "What about today would you like to happen again?",
        "What are you looking forward to tomorrow?",
        "What lessons did you learn that you'd like to share with others?",
        "Did you get to meet someone new today?"
    };

    // Method to pick and return a random prompt from list
    public string PickRandomPrompt() 
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}