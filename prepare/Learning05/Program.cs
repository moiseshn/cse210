using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Shape> shapes = new List<Shape>();
        
        Square sq1 = new Square("Blue",3);
        shapes.Add(sq1);

        Rectangle rec1 = new Rectangle("Red",4,3);
        shapes.Add(rec1);

        Circle cir1 = new Circle("Yellow",9);
        shapes.Add(cir1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"{color} has an area of {area}");
        }
    }
}