// Aided By AI and Jada Bower
public class Word
{
    private string _word; // holds the word 
    private string _blank; // holds the blanks for each letter in each _word
    private string _displayedWord; // This is what is seen by user. Switches from _word to blank.

    // Setter for word
    public void SetWord(string w)
    {
        _word = w;
        _displayedWord = _word;
    }
    
    // creates the blanks for the words and returns the blanks
    // is only used in this program directly by ReplaceDisplayedWordWithBlank
    // which is why it's private
    private string CreateBlank()
    {

        foreach (char c in _word)
        {  
            _blank += "_";
                    
        }
        // // remove the space after the last blank
        // _blank = _blank.Remove(_blank.Length - 1);
        return _blank;
    }

   // Getter for _displayedWord. Sets _displayed word to _word and 
   // returns _displayedWord
   public string GetDisplayedWord()
   {
        return _displayedWord;
   }

   // This method changes the displayed word from the actual word to blanks
   // and returns the blanks
   public string ReplaceDisplayedWordWithBlanks()
   {
        _displayedWord = CreateBlank();
        return _displayedWord;
   }
}