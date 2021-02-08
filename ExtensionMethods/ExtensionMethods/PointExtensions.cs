using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class PointExtensions
    {
        public static void Rotate(this Point p, double angleDegrees)
        {
            double angleRadians = (Math.PI / 180) * angleDegrees;

            // see: https://en.wikipedia.org/wiki/Rotation_matrix
            double originalX = p.X;
            double originalY = p.Y;

            p.X = originalX * Math.Cos(angleRadians) - originalY * Math.Sin(angleRadians);
            p.Y = originalX * Math.Sin(angleRadians) + originalY * Math.Cos(angleRadians);
        }

        public static void Translate(this Point p, int dx, int dy)
        {
            p.X += dx;
            p.Y += dy;
        }

        public static void Print(this Point p)
        {
            Console.WriteLine($"Point (X={p.X}, Y={p.Y})");
        }
    }
}
