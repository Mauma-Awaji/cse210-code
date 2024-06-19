using System.IO;

// Aided by ChatGPT and Levi Jones

public class Journal{

    // List that'll contain the user's entries before they are added to the txt file
    public List<Entry> _entries = new List<Entry>();
    string _fileName;

    // Method to add the user's entries to the lists
    public void AddEntriesToList(Entry entry) {
        _entries.Add(entry);
    }
   
   // Method that will save the entries in the list to a txt file
   // Currently this method overwrites everything currently in said txt file
   // LoadEntries is recommended first
    public void SaveEntries() {
        Console.Write("What file would you like to save this to?\n >");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.FileDisplay());
            }

        }
        Console.WriteLine("Entries saved to file");

    }

    // This method displays all the entries that are in the list
    public void ShowEntries() {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.Display());
        }
    }

    // This method takes all the entries in the txt file and puts them into the list
    public List<Entry> LoadEntries() 
    {
        _entries = new();
        Console.Write("Select file to load\n  > ");
        _fileName = Console.ReadLine();
        string [] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {   
            // Console.WriteLine(line);
            // Split each line into parts using "|" as the delimiter
            string[] parts = line.Split("|");

            // Create new entry instance that is filled by entries in the text file
            Entry oldEntry = new Entry(parts[0], parts[1], parts[2]);

            _entries.Add(oldEntry);        
        }
        Console.WriteLine("\nFile has been loaded");
        return _entries;
    }


}