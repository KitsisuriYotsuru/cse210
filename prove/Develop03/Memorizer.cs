class Memorizer
{
    private Scripture scripture;

    public Memorizer(Scripture scripture)
    {
        this.scripture = scripture;
    }

    public bool RunMemorizer(Menu menu)
    {
        Console.WriteLine($"{scripture.Reference.GetReference()}\n{scripture.GetText()}");
        Console.WriteLine(" ");
        Console.Write("Press Enter to hide words or q to quit");
        string input = menu.GetUserInput();
        if (input == "")
        {
            scripture.HideWords();
            return false;
        }
        else if (input == "q")
        {
            return true;
        }
        else
        {
            Console.WriteLine("Incorrect input");
            return false;
        }
        
    }
}