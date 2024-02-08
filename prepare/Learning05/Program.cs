using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 2);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 5, 6);
        shapes.Add(rectangle);

        Circle circle = new Circle("Black", 5);
        shapes.Add(circle);


        foreach (Shape shape in shapes)
        {
            
            string color = shape.GetColor();
            double area = shape.GetArea();
            
            Console.WriteLine($"The {color} shape has an area of {area}.");
             
        }
        Console.WriteLine();

    }
}