using System;

public class Circle
{
    private double radius;

    public Circle()
    {
        radius = 0;
    }

    public double Radius
    {
        get { return radius; }
    }

    public void SetRadius(double value)
    {
        if (value > 0)
        {
            radius = value;
        }
        else
        {
            throw new InvalidRadiusException(value);
        }
    }

    public override string ToString()
    {
        return $"Circle with radius: {radius}";
    }
}

public class InvalidRadiusException : Exception
{
    public InvalidRadiusException() : base("Invalid radius! Radius must be greater than zero.") { }

    public InvalidRadiusException(double radius) : base($"Invalid radius: {radius}. Radius must be greater than zero.") { }
}

class MainClass
{
    public static void Main(string[] args)
    {
        try
        {
            Circle circle1 = new Circle();
            circle1.SetRadius(5);
            Console.WriteLine(circle1);

            Circle circle2 = new Circle();
            circle2.SetRadius(-2); // This should throw an exception
            Console.WriteLine(circle2);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Circle circle3 = new Circle();
            circle3.SetRadius(0); // This should throw an exception
            Console.WriteLine(circle3);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
