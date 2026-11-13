using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();

        Square sq1 = new Square("yellow", 16);
        shapeList.Add(sq1);

        Rectangle rc1 = new Rectangle(3, 5, "pink");
        shapeList.Add(rc1);

        Circle cr1 = new Circle(4, "green");
        shapeList.Add(cr1);

        foreach(Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
        

    }
}