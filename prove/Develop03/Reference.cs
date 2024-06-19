// Aided By AI and Emma "Jojo" Johnson and Jada Bower

public class Reference
{
   private string _chapter; // e.g 1 Nephi 1
   private int _verse;
   private int _startVerse;
   private int _endVerse = 0;

   public Reference (string chap, int ver) {
    _verse = ver;
    _chapter = chap;
   }
   public Reference (string chap, int startVer, int endVer) {
    _startVerse = startVer;
    _endVerse = endVer;
    _chapter = chap;
   }

   public static string StringVerse (int ver) 
   {
    string strVer = ver.ToString();
    return strVer;
   }

   public string GetReferenceVerse ()
   {
      if (_endVerse == 0)
      {
         return _chapter + ":" + StringVerse(_verse);
      }
      else
      {
         return _chapter + ":" + StringVerse(_startVerse)  + "-" + StringVerse(_endVerse);
      }


   }

}
