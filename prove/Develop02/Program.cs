using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Menu menu = new Menu(journal);

        bool exit = false;
        while (!exit)
        {
            string input = menu.GetUserInput();
            switch (input)
            {
                case "1":
                    JournalEntry journalEntry = new JournalEntry();
                    journalEntry.CreateEntry();
                    journal.AddNewEntry(journalEntry);
                    break;
                case "2":
                    journal.DisplayJournalEntries();
                    break;
                case "3":
                    Console.Write("Enter The File Name: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;
                case "4":
                    Console.Write("Enter The File Name: ");
                    string readFileName = Console.ReadLine();
                    journal.ReadFromFile(readFileName);
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}