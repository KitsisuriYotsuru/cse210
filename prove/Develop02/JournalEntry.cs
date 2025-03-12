class JournalEntry
{
    private string _entryText;
    private string _question;
    private string _date;

    public JournalEntry()
    {
        _date = "";
        _question = "";
        _entryText = "";
    }

    public JournalEntry(string date, string question, string entryText)
    {
        _date = date;
        _question = question;
        _entryText = entryText;
    }

    public void CreateEntry()
    {
        Questions questions = new Questions();
        string question = questions.GetQuestion();

        Console.WriteLine(question);
        Console.Write("> ");
        string entryText = Console.ReadLine();
        
        // Fix the date to be the current date
        DateTime date = DateTime.Now;

        _date = date.ToString("MM/dd/yyyy");
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
        string outputString = $"{_date}#{_question}#{_entryText}";

        return outputString;
    }
}