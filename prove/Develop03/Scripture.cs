using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;


// Aided By AI, Adam Dombroski and Jada Bower
public class Scripture
{
    private Reference _ref;
    private List<Word> _words = new();
    private Boolean _completelyHidden; // This becomes true when all the words have been replaced with blanks


    public void SetWords(Word word) 
    {
        // Setter for _words
        _words.Add(word);
    }

    public void SetRef(Reference r)
    {
        _ref = r;
    }
    public void DisplayScripture()
    {
        Console.Write($"{_ref.GetReferenceVerse()}: ");
        for (int i = 0; i < _words.Count; i++)
        {
            Console.Write($"{_words[i].GetDisplayedWord()} ");
        }
        Console.WriteLine();
;
    }

    public void HideThreeRanWords() // Replace up to three random words with blanks
    {


        int count = 3; // Number of items to select
        Random random = new();

        // while (_completelyHidden == false)
        // {
            for (int i = 0; i < count; i++)
            {  
                bool hasBlanks = true;
                int index = random.Next(_words.Count); 
                while (hasBlanks == true)
                {
                    if (_words[index].GetDisplayedWord().Contains('_'))
                    {
                        if (_words.TrueForAll(s => s.GetDisplayedWord().StartsWith('_')))
                        {
                            _completelyHidden = true;
                            break;
                        }
                        else
                        {
                            index = random.Next(_words.Count);
                        }
                        
                    }
                    else
                    {
                        _words[index].ReplaceDisplayedWordWithBlanks();
                        hasBlanks = false;

                    }
                }           
            // }
        }
      
        DisplayScripture();

    }

    public Boolean GetCompletelyHidden()
    {
        return _completelyHidden;
    }
}