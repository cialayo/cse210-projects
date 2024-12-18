using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 4);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("yellow", 3, 2);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("blue", 3);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The color is: {shape.GetColor()}");
            Console.WriteLine($"The area is: {shape.GetArea():F2}");
        }
    }
}