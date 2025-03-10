class JournalEntry
{
    private string _entryText;
    private string _question;
    private string _date;

    public JournalEntry(string date, string question, string entryText)
    {
        _date = date;
        _question = question;
        _entryText = entryText;
    }

    public void CreateEntry(string question)
    {
        string entryText = Console.ReadLine();

        DateTime date = new DateTime();

        _date = date.ToShortDateString();
        _question = question;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.Write($"{_date}: ");
        Console.WriteLine($"{_question}");
        Console.WriteLine(_entryText);
    }

    public string CreateFileSystemString()
    {
        string outputString = $"{_date}#{_question}#{_entryText}#";

        return outputString;
    }
}