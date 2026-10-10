class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    

    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry entry = new JournalEntry();
        entry.CreateJournalEntry();
        _entries.Add(entry);
    }

    public void ReadFromFile(string filename)
    {
    string[] lines = System.IO.File.ReadAllLines(filename);
    _entries.Clear();
    foreach (string line in lines)
      {
       
        JournalEntry entry = new JournalEntry();
        string[] parts = line.Split("#");
        string date = parts[0];
        string question = parts[1];
        string entryText = parts[2];
        
		entry._date = date;
        entry._prompt = question;
        entry._response = entryText;

        _entries.Add(entry);

      }
    }

    

    public void WriteToFile(string filename) 
    { 
        using (StreamWriter outputFile = new StreamWriter(filename)) 
        { 
            foreach(JournalEntry entry in _entries) 
            { 
                outputFile.WriteLine(entry.CreateFileSystemString()); 
            }
        }
    }
}