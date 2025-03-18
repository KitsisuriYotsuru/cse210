using System;

class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        List<Scripture> scriptures = menu.GetScriptures();
        bool exit = false;
        while (!exit)
        {
            // Get user input from the menu
            menu.DisplayMenu();
            string input = menu.GetUserInput();

            switch (input)
            {
                case "1":
                    int i = 1;
                    Console.WriteLine("select a scripture you would like to memorize");
                    foreach(Scripture scripture in scriptures)
                    {
                        Console.WriteLine($"{i}. {scripture.Reference.GetReference()}");
                        i++;
                    }

                    input = menu.GetUserInput();
                    Scripture selectedScripture = scriptures[int.Parse(input) - 1];
                    Memorizer memorizer = new Memorizer(selectedScripture);
                    bool quit = false;
                    while(!quit)
                    {
                        Console.Clear();
                        quit = memorizer.RunMemorizer(menu);
                    }
                    break;
                case "2":
                    Console.WriteLine("WIP");
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}