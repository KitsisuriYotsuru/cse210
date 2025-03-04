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

    public double GetCircumference()
    {
        double circumference = 2 * Math.PI * radius;
        return circumference;
    }

    public double GetDiameter()
    {
        double diameter = radius * 2;
        return diameter;
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