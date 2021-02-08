using System;

namespace ExtensionMethods
{
    public class Triangle : IShape
    {
        public Triangle(Point p1, Point p2, Point p3)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
        }

        public Point P1
        {
            get;
        }

        public Point P2
        {
            get;
        }

        public Point P3
        {
            get;
        }

        public Point[] Points
        {
            get
            {
                return new Point[] { P1, P2, P3 };
            }
        }

        public double GetArea()
        {
            // see: https://www.mathopenref.com/coordtrianglearea.html
            double area = Math.Abs(P1.X * (P2.Y - P3.Y) + P2.X * (P3.Y - P1.Y) + P3.X * (P1.Y - P2.Y)) / 2;
            return Math.Round(area, 2);
        }
    }
}
