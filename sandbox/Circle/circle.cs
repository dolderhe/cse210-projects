class Circle
{

    private double _radius;

    public Circle()
    {
        _radius = 1.0;
    }

    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public Circle(int radius)
    {
        SetRadius(radius);
    }

// Depending on your desires with this method you can
// Make it public (if the client should be able to change the radius at will)
// or private if you don't want that.
    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            _radius = 1.0;
            Console.WriteLine("Invalid value, must be >= 0");
        }
        else
        {
            _radius = radius;
        }
    }
    

    public double GetArea()
    {
        return 3.14159 * _radius * _radius;
    }

}