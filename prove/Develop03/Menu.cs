class Menu
{
    private List<Scripture> scriptures = new List<Scripture>();

    public Menu()
    {
        string[] lines = File.ReadAllLines("data.txt");
        foreach (string line in lines)
        {
            string[] scriptureParts = line.Split('#');
            string[] referenceParts = scriptureParts[0].Split(' ');
            if(referenceParts.Length == 3)
            {
                string book = referenceParts[0] + " " + referenceParts[1];
                string chapter = referenceParts[2].Split(':')[0];
                string verses = referenceParts[2].Split(':')[1];
                Reference reference = new Reference(book, chapter, verses);
                scriptures.Add(new Scripture(reference, scriptureParts[1]));
                
            } 
            else if (referenceParts.Length == 2)
            {
                string book = referenceParts[0];
                string chapter = referenceParts[1].Split(':')[0];
                string verses = referenceParts[1].Split(':')[1];
                Reference reference = new Reference(book, chapter, verses);
                scriptures.Add(new Scripture(reference, scriptureParts[1]));            }
        }
    }

    public List<Scripture> GetScriptures() 
    {
        return scriptures;
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
        Console.Write("> ");
        string input = Console.ReadLine();
        return input;
    }
}