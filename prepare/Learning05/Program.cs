using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<shape> shapes = new List<shape>();


        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 3, 5));
        shapes.Add(new Circle("Green", 2.5));

        foreach (shape shape in shapes)
        {
            Console.WriteLine("Shape color: " + shape.GetColor());
            Console.WriteLine("Shape area: " + shape.GetArea());
            Console.WriteLine();
        }
    }
}