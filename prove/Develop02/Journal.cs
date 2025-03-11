using System.IO;

class Journal
{
    private List<JournalEntry> _entries;

    public Journal()
    {
        _entries = [];
    }

    public void AddNewEntry(JournalEntry journalEntry)
    {
        _entries.Add(journalEntry);
    }

    public void DisplayJournalEntries()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in _entries)
            {
                writer.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public void ReadFromFile(string fileName)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('#');
            Console.WriteLine(parts.Length);
            if (parts.Length == 3)
            {
                Console.WriteLine("poggies");
                JournalEntry entry = new JournalEntry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }
    }
}

