using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job myJob = new Job("Bigsoft", "programmer", 2019, 2025);
        Job myJob2 = new Job("Microsoft", "programmer", 2017, 2019);
        Resume myResume = new Resume("Olliver Hall");
        myResume.AddJob(myJob);
        myResume.AddJob(myJob2);
        
        myResume.Display();
    }
}