using System;

class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        List<Scripture> scriptures = menu.GetScriptures();
        int i = 1;
        bool exit = false;
        while (!exit)
        {
            // Get user input from the menu
            menu.DisplayMenu();
            string input = menu.GetUserInput();

            switch (input)
            {
                case "1":
                    Console.WriteLine("select a scripture you would like to memorize");
                    foreach(Scripture scripture in scriptures)
                    {
                        Console.WriteLine($"{i}. {scripture.Reference.GetReference()}");
                        i++;
                    }

                    bool quit = false;
                    while(!quit)
                    {
                        input = menu.GetUserInput();
                        Scripture selectedScripture = scriptures[int.Parse(input) - 1];
                        Console.WriteLine($"{selectedScripture.Reference.GetReference()} {selectedScripture.GetText()}");
                        
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