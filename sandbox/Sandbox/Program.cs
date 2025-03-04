using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Today - March 3, 2025");

        // double x = 10;
        Circle myCircle = new Circle(5);
        myCircle.DisplayCircleArea();
        Cylinder myCylinder = new Cylinder(10, myCircle);
        myCylinder.DisplayCylinderVolume();

        
        // Circle myCircle2 = new Circle(20);
        // myCircle2.DisplayCircleArea();



        // for(int i = 0; i < 30; i++)
        // {
        //     myCircle.SetRadius(i);
        //     myCircle.DisplayCircleArea();
        // }
    }
}