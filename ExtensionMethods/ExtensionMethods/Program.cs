using System;
using System.Threading;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            Point p1 = new Point(10, 20);
            string coords = p1;
            Console.WriteLine(coords);

            // explicit conversion
            Point p2 = (Point)"[100, aaa]";
            p2.Print();

            IShape t = new Triangle(new Point(15, 15), new Point(23, 30), new Point(50, 25));
            t.Print();

            // t.Rotate(90);
            t.Translate(50, 50);
            t.Print();
        }
    }
}
