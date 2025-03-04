class Cylinder
{
    private double height;
    private Circle circle;

    public Cylinder(double h, Circle c)
    {
        height = h;
        circle = c;
    }

    public double GetVolume()
    {
        double volume = circle.GetArea() * height;
        return volume;
    }

    public void SetHeight(double height)
    {
        this.height = height;
    }

    public void SetCircle(Circle circle)
    {
        this.circle = circle;
    }

    public void DisplayCylinderVolume()
    {
       Console.WriteLine($"The volume of the cylinder with a diameter of {circle.GetDiameter()} and a height of {height} is: {GetVolume()}");
    }
}