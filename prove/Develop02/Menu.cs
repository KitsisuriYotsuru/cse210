class Menu
{
    private Journal _journal;

    public Menu(Journal journal)
    {
        _journal = journal;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Add a new journal entry");
        Console.WriteLine("2. Display all journal entries");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Exit");
    }

    public string GetUserInput()
    {
        DisplayMenu();
        Console.WriteLine("> ");
        string input = Console.ReadLine();
        return input;
    }
}