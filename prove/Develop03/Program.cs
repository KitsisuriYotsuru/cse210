using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        List<Reference> references = menu.GetReferences();
        int i = 0;
        bool exit = false;
        while (!exit)
        {
            // Get user input from the menu
            string input = menu.GetUserInput();

            switch (input)
            {
                case "1":
                    foreach(Reference reference in references)
                    {
                        Console.WriteLine($"{i}. {reference}");
                        i++;
                    }
                    input = menu.GetUserInput();
                    Scripture scripture = new Scripture(references[int.Parse(input)]);
                    break;
                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}