class Menu
{
    public Menu()
    {

    }

    public void DisplayMenu()
    {
        Console.WriteLine("1.Start Breathing Activity.");
        Console.WriteLine("2.Start Reflection Activity.");
        Console.WriteLine("3.Start Listing Activity.");
        Console.WriteLine("4.Quit.");
    }

    public string GetResponse()
    {
        Console.Write(">");
        return Console.ReadLine();
    }
}