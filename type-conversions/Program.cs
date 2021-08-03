using System;

namespace type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(100, 200);
            string coords = p1;
            Console.WriteLine(coords);

            Point p2 = (Point)coords;
            Console.WriteLine($"Point: ({p2.X}, {p2.Y})");

            Point p3 = p1 + p2;
            Console.WriteLine($"Point sum: ({p3.X}, {p3.Y})");
        }
    }
}
