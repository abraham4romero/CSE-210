using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Shape rectangle = new Rectangle(5, 6, "Blue");

        shapes.Add(rectangle);
        Shape square = new Square(7, "Red");
        shapes.Add(square);
        Shape circle = new Circle(20, "Green");
        shapes.Add(circle);

        foreach (Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}