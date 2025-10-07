using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("blue", 5);
        //Console.WriteLine($"{square1.GetColor()}");
        //Console.WriteLine($"{square1.GetArea()}");

        Rectangle rectangle1 = new Rectangle("red", 7, 4);
        //Console.WriteLine($"{rectangle1.GetColor()}");
        //Console.WriteLine($"{rectangle1.GetArea()}");

        Circle circle1 = new Circle("yellow", 8);
        //Console.WriteLine($"{circle1.GetColor()}");
        //Console.WriteLine($"{circle1.GetArea()}");

        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}