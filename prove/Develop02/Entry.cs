using System.Net.Security;
using System.Xml;

public class Entry
    // Aided by ChatGPT, Bro Gibbons and Levi Jones
    {
    // // Testing stuff out
    // public void Hello(){
    //     Console.WriteLine("hello world!");
    // }

    DateTime _currentTime;
    public string _dateTime; 
    
    public string _response;
    Prompt _makePrompt;
    public string _prompt;

   // Constructor that intitializes Entry without requiring an input
    public Entry()
    {
    }
    
    // Constructor that intitializes Entry and requires three inputs
    // The current date&time, the random prompt, and the user's response
    public Entry(string dt, string p, string res)
    {
        // _dateTime = currentTime.ToShortDateString();
        // _prompt = _makePrompt.PickRandomPrompt();
        _dateTime = dt;
        _prompt = p;
        _response = res;
    }

    // This method displays the date&time, the prompt generated, and the users resonse
    public string Display() 
    {

        return "\n  " + _dateTime + "\n" + "  > " + _prompt + "\n" + "  > " + _response + "\n=--------------------------------------------------------------------------------=\n";  

    }

// This method displays everything in one line with "|" as a delimiter between the stuff
// The way Display() is set up looks cool but makes it complicated for the LoadEntries()
// in Journal to call the text from the file
    public string FileDisplay()
    {
        return _dateTime + "|" + _prompt + "|" + _response ;
    }

    // This method 1) shows the current date
    // 2) Generates a random prompt using the Prompt class and displays it
    // 3) Collects the user's response
    public void PromptForResponse() 
    {          
        _currentTime = DateTime.Now;
        _makePrompt = new();
        _dateTime = _currentTime.ToShortDateString();
        Console.WriteLine(_dateTime);
        _prompt = _makePrompt.PickRandomPrompt();
        Console.WriteLine(_prompt);
        Console.Write(" >");
        _response = Console.ReadLine();
    }
}

