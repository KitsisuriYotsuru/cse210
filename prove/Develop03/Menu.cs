class Menu
{
    private List<Reference> references;
    
    public List<Reference> GetReferences() 
    {
        return references;
    }

    public Menu()
    {
        string[] lines = File.ReadAllLines("data.txt");
        foreach (string line in lines)
        {
            string[] scriptureParts = line.Split('#');
            string[] referenceParts = scriptureParts[0].Split(' ');
            string book = referenceParts[0] + " " + referenceParts[1];
            string chapter = referenceParts[2].Split(':')[0];
            string verses = referenceParts[2].Split(':')[1];
            references.Append(new Reference(book, chapter, verses));
        }
    }    
    public void DisplayMenu()
    {
        Console.WriteLine($"Welcome to the Scripture Memorizer");
        Console.WriteLine($"");
        Console.WriteLine($"1. Select a scripture to memorize");
        Console.WriteLine($"2. Add a new scripture");
        Console.WriteLine($"3. Quit");
    }

    public string GetUserInput()
    {
        DisplayMenu();
        Console.WriteLine("> ");
        string input = Console.ReadLine();
        return input;
    }
}