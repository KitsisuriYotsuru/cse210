using System;

class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        double area = Math.PI * radius * radius;
        return area;
    }

    public void DisplayCircleArea()
    {
       Console.WriteLine($"The area of the circle with radius {radius} is: {GetArea()}");
    }

    public void SetRadius(double radius)
    {
        this.radius = radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Today - March 3, 2025");

        // double x = 10;
        Circle myCircle = new Circle(10);
        myCircle.DisplayCircleArea();
        Circle myCircle2 = new Circle(20);
        myCircle2.DisplayCircleArea();

        for(int i = 0; i < 30; i++)
        {
            myCircle.SetRadius(i);
            myCircle.DisplayCircleArea();
        }
    }
}