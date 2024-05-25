class Reference{
   string _chapter;
   int _verse;
   int _startVerse;
   int _endVerse;

   Reference (int ver) {
    _verse = ver;
   }
   Reference (int startVer, int endVer) {
    _startVerse = startVer;
    _endVerse = endVer;
   }

   string StringVerse (int ver) 
   {
    string strVer = ver.ToString();
    return strVer;
   }

   
}
