// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        PoliceMan policeMan = new PoliceMan("gun", "jim", "hill", 32, 198);
        Console.WriteLine(policeMan.DisplayPoliceManInfo());
    }
}