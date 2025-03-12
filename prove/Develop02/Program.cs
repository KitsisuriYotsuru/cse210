using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Journal instance
        Journal journal = new Journal();
        // Create a new Menu instance with the journal
        Menu menu = new Menu(journal);

        bool exit = false;
        while (!exit)
        {
            // Get user input from the menu
            string input = menu.GetUserInput();
            switch (input)
            {
                case "1":
                    // Create a new journal entry and add it to the journal
                    JournalEntry journalEntry = new JournalEntry();
                    journalEntry.CreateEntry();
                    journal.AddNewEntry(journalEntry);
                    break;
                case "2":
                    // Display all journal entries
                    journal.DisplayJournalEntries();
                    break;
                case "3":
                    // Save journal entries to a file
                    Console.Write("Enter The File Name: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;
                case "4":
                    // Read journal entries from a file
                    Console.Write("Enter The File Name: ");
                    string readFileName = Console.ReadLine();
                    journal.ReadFromFile(readFileName);
                    break;
                case "5":
                    // Exit the program
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