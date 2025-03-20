using System;
using System.Xml;

class Program
{

    static void RunSpinner(string loadingString)
    {
        string spinnerString = "\\|/-"; 
        int counter = 0;
        while (counter < 4)
        {
            string output = $"{spinnerString[counter]} {loadingString} {spinnerString[counter]}";
            Console.Write(output);
            Thread.Sleep(250);
            int length = 0;
            while (length < output.Length)
            {
                Console.Write("\b");
                length++;
            }
            counter++;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Today - March 3, 2025");
        string loadingString = "Your Program is loading";
        int loadingtime = 10;
        while (loadingtime != 0)
        {
            RunSpinner(loadingString);
            loadingtime--;
        }
        // double x = 10;
        // Circle myCircle = new Circle(5);
        // myCircle.DisplayCircleArea();
        // Cylinder myCylinder = new Cylinder(10, myCircle);
        // myCylinder.DisplayCylinderVolume();

        
        // Circle myCircle2 = new Circle(20);
        // myCircle2.DisplayCircleArea();



        // for(int i = 0; i < 30; i++)
        // {
        //     myCircle.SetRadius(i);
        //     myCircle.DisplayCircleArea();
        // }


    }
}